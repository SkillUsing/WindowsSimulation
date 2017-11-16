using System;
using System.Diagnostics;
using XGLib;



namespace dm
{
    /// <summary>
    /// 游戏对象
    /// 实例化游戏对象进而方便多线程
    /// </summary>
    public class GameObjTaskModel
    {
        /// <summary>
        /// 全局路径(不允许改变,方便打包)
        /// </summary>
        private static readonly string Path = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// 阴阳师对象
        /// </summary>
        public XGDm Yys { get; set; }

        public RabbitUI Form { get; set; }

        /// <summary>
        ///  阴阳师窗体句柄对象
        /// </summary>
        private IntPtr HwndCurrent { get; set; }

        /// <summary>
        /// 破解大漠收费限制
        /// 线程内,不能是静态
        /// </summary>
        public void CrackingDm()
        {
            var process = Process.GetProcessesByName("dm");
            foreach (ProcessModule ex in process[0].Modules)
            {
                if (ex.FileName != Path) continue;
                var offsetByDm = IntPtr.Add(ex.BaseAddress, 0x1063D0);
                MemoryApi.WriteMemoryValue(offsetByDm, "dm", 1);
            }
            Form.SetLog($"大漠版本号:{Yys.Ver()}");
            var x = Yys.DmGuard(1, "np");
            // ReSharper disable InterpolatedStringExpressionIsNotIFormattable
            Form.SetLog($"防护盾开启:{x}");
            Form.SetLog($"字库设置:{Yys.SetDict(0, $"{Path}tt.txt")}");
            // ReSharper restore InterpolatedStringExpressionIsNotIFormattable
        }


        /// <summary>
        /// 构造阴阳师游戏对象
        /// </summary>
        public static GameObjTaskModel GetYysGameObject(RabbitUI form)
        {
            var yysModel = new GameObjTaskModel();
            var path = $"{Path}dm.dll";
            XGDm.DllPath = path;
            yysModel.Yys = new XGDm();
            yysModel.Yys.Create();
            yysModel.Form = form;
            yysModel.CrackingDm();
            return yysModel;
        }
    }
}