using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XGLib;
// ReSharper disable InconsistentNaming

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
            LogTextBox.Text += "\r\n" + logMessage;
        }
    }
}
