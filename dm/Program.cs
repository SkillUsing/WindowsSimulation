using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace dm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new From());
            //Application.Run(new RabbitUI());
        }
    }
}
