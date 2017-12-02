using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace dm
{
    /// <summary>
    /// 多线程版本
    /// </summary>
    public partial class RabbitUI : Form
    {
        public RabbitUI()
        {
            InitializeComponent();
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Resources.Drag;
            Innerintptr = new ArrayList { pictureBox1.Handle };
        }

        //句柄
        private IntPtr HwndCurrent { get; set; }

        private ArrayList Innerintptr { get; }

        public List<KeyValueViewModel<Thread>> ThreadList = new List<KeyValueViewModel<Thread>>();

        public List<GameObjTaskModel> ThreadGame = new List<GameObjTaskModel>();

        public int RadioTag { get; set; }

        private bool Dragging { get; set; }

        private void RabbitUI_Load(object sender, EventArgs e)
        {

        }


        public void SetLog(string logMessage)
        {
            LogTextBox.Text += @"
" + logMessage;
        }


        #region UI

        #region TabChange
        private void GoProgressLinkLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TabControlMain.SelectTab("LogTab");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TabControlMain.SelectTab("ConfigTab");

        }

        private void GoInfoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = (LinkLabel)sender;
            if (linkLabel.Text == @"Config")
            {
                TabControlMain.SelectTab("ConfigTab");
                linkLabel.Text = @"Info";
                MainLabel.Text = @"兔兔的皮卡丘";
            }
            else
            {
                TabControlMain.SelectTab("AboutTab");
                linkLabel.Text = @"Config";
                MainLabel.Text = @"关于兔兔";
            }
        }
        #endregion

        #region Config
        private void RedioBtnChange(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            foreach (var item in FunPanel.Controls)
            {
                // ReSharper disable once CanBeReplacedWithTryCastAndCheckForNull
                if (!(item is RadioButton)) continue;
                var btn = (RadioButton)item;
                if (btn == radio && btn.Checked)
                {
                    RadioTag = Convert.ToInt32(btn.Tag);
                    //MessageBox.Show($@"{btn.Tag}");
                }
            }
        }
        #endregion




        #endregion

        #region CursorIntPtr
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Dragging = true;
            Cursor = new Cursor(new MemoryStream(Resources.Eye));
            ((PictureBox)sender).Image = Resources.Drag2;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Dragging) return;
            var intPtr = WindowsApi.WindowFromPoint(MousePosition);
            if (Innerintptr.Contains(intPtr))
            {
                intPtr = IntPtr.Zero;
            }
            if (intPtr == HwndCurrent) return;
            ApiTools.DrawRectFrame(HwndCurrent);
            ApiTools.DrawRectFrame(intPtr);
            HwndCurrent = intPtr;
            ShowIntPtr.Text = HwndCurrent.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var pictureBox = ((PictureBox)sender);
            pictureBox.Image = Resources.Drag;
            Cursor = Cursors.Default;
            if (!Dragging) return;
            Dragging = false;
        }
        #endregion

        #region StartThread
        private void Start_Click(object sender, EventArgs e)
        {
            if (HwndCurrent == IntPtr.Zero)
            {
                return;
            }
            var model = GameObjTaskModel.GetYysGameObject(this);
            model.HwndCurrent = HwndCurrent;
            model.Yys.SetAero(0);
            SetLog(@"关闭系统Aero效果");
            var x = model.Yys.BindWindowEx(HwndCurrent, "dx2", "windows3", "windows", "", 0);
            SetLog($"后台绑定:{x}");
            if (x == 1) return;
            ThreadGame.Add(model);
            var th = new Thread(() =>
                {
                    switch (RadioTag)
                    {
                        case 0:
                            YysTools.Main(model.Yys);
                            break;
                        case 1:
                            YysTools.StartYuHun(model.Yys);
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                })
            {
                IsBackground = true
            };
            ThreadList.Add(new KeyValueViewModel<Thread>()
            {
                Key = $"{RadioTag}",
                Value = th
            });
            th.Start();
        }
        #endregion


        #region EndThread
        private void buttonQueryCompact_Click(object sender, EventArgs e)
        {
            foreach (var item in ThreadList)
            {
                item.Value.Abort();
            }
            foreach (var item in ThreadGame)
            {
                item.Yys.UnBindWindow();
            }
        }

        private void RabbitUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in ThreadList)
            {
                item.Value.Abort();
            }
            foreach (var item in ThreadGame)
            {
                item.Yys.UnBindWindow();
            }
        }

        #endregion
    }
}
