using System;
using System.Net.Configuration;
using System.Windows.Forms;
using XGLib;

namespace dm
{
    public class YysTools
    {
        /// <summary>
        /// 日常
        /// </summary>
        public static void Main(XGDm dm)
        {
            var wy = 0;
            var lx = 0;
            var lx2 = 0;
            var model = new Position();
            var rd = new Random();
            var label = rd.Next(0, 5);
            var test1 = Features.NoLabel;

            var of = lx + lx2 + label * 38;
            test1.UpleftPosition = new Position(test1.UpleftPosition.X + of, test1.UpleftPosition.Y);
            test1.LowRightPosition = new Position(test1.LowRightPosition.X + of, test1.LowRightPosition.Y);
            model = dm.ColorsFunc(Features.NoLabel);

            if (model != null)
            {
                var test = Features.NoError2;

                test.UpleftPosition = new Position(model.X + 184 - lx2, model.Y - 83);
                test.LowRightPosition = new Position(model.X - 83, model.Y - 44);
                test.Dir = 1;

                model = dm.ColorsFunc(test);

                if (model != null)
                {
                    Console.WriteLine($@"找到了:{label}个牌子 --（{model.X},{model.Y}）");
                    dm.MoveToClick(model);
                }
            }
        }

        /// <summary>
        /// 结界突破
        /// </summary>
        public static void Jjtp(XGDm dm)
        {
            if (ImportExplore(dm))
            {
                if (ImportBreakthrough(dm))
                {
                    goto Finish;
                }
            }
            Finish:
            Console.WriteLine("程序结束!");
        }

        /// <summary>
        /// 进入探索
        /// </summary>
        public static bool ImportExplore(XGDm dm)
        {
            var model = dm.WhileFeatures(() => dm.ColorsFunc(Features.Explore, true), "探索");
            if (model == null) return false;
            dm.delay(200);
            dm.MoveToClick(model);
            model = dm.WhileFeatures(() => dm.ColorsFunc(Features.ReturnBtn, true), "进入探索");
            return model != null;
        }

        /// <summary>
        /// 进入结界突破
        /// </summary>
        public static bool ImportBreakthrough(XGDm dm)
        {
            var model = dm.WhileFeatures(() => dm.ColorsFunc(Features.SelectBreakthrough, true), "结界突破");
            if (model == null) return false;
            dm.delay(200);
            dm.MoveToClick(model);
            model = dm.WhileFeatures(() => dm.ColorsFunc(Features.IsBreakthrough, true), "是否进入结界突破");
            return model != null;
        }

        /// <summary>
        /// 进入突破寮
        /// </summary>
        public static bool ImportBreakthroughs(XGDm dm)
        {
            var model = dm.WhileFeatures(() => dm.ColorsFunc(Features.CzL1), "进入突破寮");
            if (model == null) return false;
            dm.delay(200);
            dm.MoveToClick(model);
            model = dm.WhileFeatures(() => dm.ColorsFunc(Features.CzL2, true), "是否进入进入突破寮");
            return model != null;
        }


        public static bool BreakthroughMain(XGDm dm)
        {
            while (true)
            {
                var wy = 0;
                var lx = 0;
                var lx2 = 0;
                var model = new Position();

                for (int i = 0; i < 3; i++)
                {
                    var gj = 0;
                    var cs = 0;
                    model = dm.ColorsFunc(Features.XhL);
                    if (model != null)
                    {
                        i = 100;
                    }
                    else
                    {
                        dm.MoveToClick(new Position(292, 47));
                    }
                    dm.delay(1000);
                }
                while (true)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var rd = new Random();
                        var label = rd.Next(0, 5);
                        var test1 = Features.NoLabel;

                        var of = lx + lx2 + label * 38;
                        test1.UpleftPosition = new Position(test1.UpleftPosition.X + of, test1.UpleftPosition.Y);
                        test1.LowRightPosition = new Position(test1.LowRightPosition.X + of, test1.LowRightPosition.Y);
                        model = dm.ColorsFunc(Features.NoLabel,true);

                        if (model != null)
                        {
                            var test = Features.NoError2;

                            test.UpleftPosition = new Position(model.X + 184 - lx2, model.Y - 83);
                            test.LowRightPosition = new Position(model.X - 83, model.Y - 44);
                            test.Dir = 1;

                            model = dm.ColorsFunc(test,true);

                            if (model != null)
                            {
                                Console.WriteLine($@"找到了:{label}个牌子 --（{model.X},{model.Y}）");
                                dm.MoveToClick(model);
                            }
                        }
                    }
                    lx = 0;
                }

            }
        }
    }
}



