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

        private bool Dragging { get; set; }

        private void RabbitUI_Load(object sender, EventArgs e)
        {
            //1.创建大漠对象
            var model = GameObjTaskModel.GetYysGameObject(this);
            //2.以Model创建线程
            Console.WriteLine(model);
            //3.执行对应方法
        }


        public void SetLog(string logMessage)
        {
            LogTextBox.Text += @"
" + logMessage;
        }

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
            if (!Dragging) return;
            Dragging = false;
            Cursor = Cursors.Default;
            if (HwndCurrent == IntPtr.Zero) return;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var th = new Thread(() =>
            {
                
            }) {IsBackground = true};
            ThreadList.Add(new KeyValueViewModel<Thread>()
            {
                Key = "",
                Value = th
            });
            th.Start();
        }

    }
}
