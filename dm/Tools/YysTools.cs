using System;
using System.Windows.Forms;
using XGLib;

namespace dm
{
    public class YysTools
    {
        /// <summary>
        /// 日常
        /// </summary>
        public void Main()
        {

        }

        /// <summary>
        /// 结界突破
        /// </summary>
        public static void Jjtp(XGDm dm)
        {
            if (!WhileOrcClick(() => dm.GetPositionByOcr("探", "1A120B-0B0802"), dm, "探索灯笼"))
            {
                goto Finish;
            }
            if (!WhileOrcClick(() => dm.GetPositionByOcr("结界突破", "CCC6B5-2C2D2B", new Position(48, 552), new Position(623, 627)), dm, "结界突破按钮"))
            {
                goto Finish;
            }
            dm.delay(500);
            dm.MoveToClick(new Position(1092, 303));


        Finish:
            Console.WriteLine("程序结束!");
        }

        //循环执行找
        public static bool WhileOrcClick(Func<Position> func, XGDm dm, string logName = "")
        {
            var i = 0;
            while (true)
            {
                i++;
                var pos = func.Invoke();
                if (pos == null)
                {
                    Console.WriteLine($"{logName}-找寻失败!正在重试,第{i}次!");
                    if (i > 500)
                    {
                        Console.WriteLine($"{logName}-找寻失败!超过500次,判定脚本失败!");
                        return false;
                    }
                    dm.delay(200);
                    continue;
                }
                dm.delay(2000);
                dm.MoveToClick(pos);
                return true;
            }
        }
    }
}