using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XGLib;

namespace dm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Resources.Drag;
            Innerintptr = new ArrayList { pictureBox1.Handle };
        }

        private bool Dragging { get; set; }

        private IntPtr HwndCurrent { get; set; }

        private ArrayList Innerintptr { get; }

        private readonly XGDm _dm = new XGDm();

        private readonly string _path = AppDomain.CurrentDomain.BaseDirectory;

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = $"{_path}dm.dll";
            XGDm.DllPath = path;
            _dm.Create();
            var process = Process.GetProcessesByName("dm");
            foreach (ProcessModule ex in process[0].Modules)
            {
                if (ex.FileName != path) continue;
                var offsetByDm = IntPtr.Add(ex.BaseAddress, 0x1063D0);
                MemoryApi.WriteMemoryValue(offsetByDm, "dm", 1);
            }
            Console.WriteLine("大漠版本号：" + _dm.Ver());
            var x = _dm.DmGuard(1, "np");
            Console.WriteLine("防护盾开启:" + x);
            x = _dm.SetDict(0, $"{_path}tt.txt");
            Console.WriteLine("字库设置:" + x);
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
            _dm.UnBindWindow();
            ApiTools.DrawRectFrame(HwndCurrent);
            ApiTools.DrawRectFrame(intPtr);
            HwndCurrent = intPtr;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var pictureBox = ((PictureBox)sender);
            pictureBox.Image = Resources.Drag;
            if (!Dragging) return;
            Dragging = false;
            Cursor = Cursors.Default;
            if (HwndCurrent == IntPtr.Zero) return;
            ApiTools.DrawRectFrame(HwndCurrent);
            _dm.SetAero(0);//关闭Aero
            //后台绑定且隐藏dll
            var x = _dm.BindWindowEx(HwndCurrent, "dx2", "windows3", "windows", "", 0);
            Console.WriteLine("后台绑定:" + x);
        }

        private void GetBindPic()
        {
            var time = DateTime.Now.ToString("hh-mm-ss");
            var picPath = $"{AppDomain.CurrentDomain.BaseDirectory}test{time}.bmp";
            Console.WriteLine(picPath);
            var x = _dm.Capture(0, 0, 2000, 2000, picPath);
            Console.WriteLine(x);
            Console.WriteLine(_dm.GetLastError());
            _dm.delay(1000);
            try
            {
                using (var fs = File.OpenRead(picPath))
                {
                    var filelength = (int)fs.Length;
                    var image = new byte[filelength];
                    fs.Read(image, 0, filelength);
                    var result = Image.FromStream(fs);
                    PicShow.Image = result;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetBindPic();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dm.UnBindWindow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _dm.UnBindWindow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YysTools.Jjtp(_dm);
        }

        public (int x, int y)? StringToPosition(string str)
        {
            var ary = str.Split('|');
            var x = int.Parse(ary[1]);
            var y = int.Parse(ary[2]);
            if (x > 0)
            {
                return (x, y);
            }
            return null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YysTools.Main(_dm);
        }
    }
}
