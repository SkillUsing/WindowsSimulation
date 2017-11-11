using System;
using System.Net;
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
            //第一行
            //第一列        第二列
            //426,161 -295- 721,161
            //295,113      
            //721,274   -   1021,274

            //         120

            //第二行
            //第一列        第二列
            //426,281 -295- 721,281
            //         113
            //721,394   -   1021,394


            var rd = new Random();

            var error = 0;
            //第几行
            var row = 0;
            //第几列
            var col = 0;
            while (error < 20)
            {
                var upleft = new Position(426 + col * 295, 161 + row * 120);
                var downRight = new Position(721 + col * 300, 274 + row * 120);

                //Console.WriteLine($"坐标:({upleft.X},{upleft.Y})-({downRight.X},{downRight.Y})");
                //var time = DateTime.Now.ToString("hh-mm-ss");
                //var picPath = $"{AppDomain.CurrentDomain.BaseDirectory}test{time}.bmp";
                //Console.WriteLine(picPath);
                //dm.Capture(upleft.X + 79, upleft.Y, downRight.X, downRight.Y, picPath);

                //截小图 判断牌子更精确
                var orc = upleft;
                orc.X += 79;
                dm.delay(200);
                var count = dm.GetFindStr("牌子", "B19C85-040608", orc, downRight);
                Console.WriteLine($"牌子:{5 - count}个");
                dm.delay(200);
                var pos = dm.GetPositionByOcr("突破失败", "483527-030303", orc, downRight);
                if (pos != null)
                {
                    Console.WriteLine($"挑战失败:{pos.X},{pos.Y}");
                }
                else
                {
                    orc.X += 40;
                    orc.Y += 40;
                    dm.MoveToClick(orc);
                    dm.delay(500);
                    var attackBtn = Features.AttackBtn;
                    attackBtn.Dir = 3;
                    var model = dm.ColorsFunc(attackBtn);
                    if (model != null)
                    {
                        Console.WriteLine($"坐标:{model.X},{model.Y}");
                        dm.MoveToClick(model);
                        //战斗开始
                        //循环检测准备按钮
                        model = dm.WhileFeatures(() => dm.ColorsFunc(Features.Prepare), "战斗准备");
                        if (model != null)
                        {
                            dm.delay(2000);
                            Console.WriteLine($"准备:{model.X},{model.Y}");
                            dm.MoveToClick(model);
                            //循环检测战斗是否结束
                            var isNotOk = true;
                            while (isNotOk)
                            {
                                dm.delay(200);
                                pos = dm.GetPositionByOcr("战斗结束", "7E9DA7-5E5556", new Position(415, 525), new Position(449, 566));
                                if (pos == null) continue;
                                dm.delay(500);
                                dm.MoveToClick(pos);
                                isNotOk = false;
                                col = 0;
                                row = 0;
                            }
                        }
                    }
                }
                col += 1;
                if (col > 1)
                {
                    col = 0;
                    row += 1;
                }
                if (row > 2)
                {
                    row = 0;
                    MoveDown(dm);
                }
                error++;
                dm.delay(500);
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

        /// <summary>
        /// 鼠标下移6次
        /// </summary>
        public static void MoveDown(XGDm dm)
        {
            dm.MoveTo(690, 406);
            dm.delay(200);
            dm.WheelDown();
            dm.delay(200);
            dm.WheelDown();
            dm.delay(200);
            dm.WheelDown();
            dm.delay(200);
            dm.WheelDown();
            dm.delay(200);
            dm.WheelDown();
            dm.delay(200);
            dm.WheelDown();
        }


        public static bool BreakthroughMain(XGDm dm)
        {

            return true;
        }
    }
}



