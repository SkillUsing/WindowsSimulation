using System;
using XGLib;

namespace dm
{
    /// <summary>
    /// 阴阳师工具类
    /// </summary>
    public class YysTools
    {
        /// <summary>
        /// 日常
        /// </summary>
        public static void Main(XGDm dm)
        {
            BreakthroughMain(dm);
        }

        /// <summary>
        /// 结界突破
        /// </summary>
        public static void Jjtp(XGDm dm)
        {
            //if (ImportExplore(dm))
            //{
            //    if (ImportBreakthrough(dm))
            //    {
            //        goto Finish;
            //    }
            //}
            //Finish:
            //Console.WriteLine("程序结束!");
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


        /// <summary>
        /// 刷结界突破
        /// </summary>
        /// <param name="dm"></param>
        public static void BreakthroughMain(XGDm dm)
        {
            var l = new Position(245, 175);
            var error = 0;
            Start:
            if (error > 2000)
            {
                goto Finish;
            }
            dm.delay(200);
            dm.MoveToClick(l);
            dm.delay(500);
            dm.MoveToClick(l);
            //第几行
            var row = 0;
            //第几列
            var col = 0;
            while (error < 200)
            {
                var upleft = new Position(426 + col * 295, 161 + row * 120);
                var downRight = new Position(721 + col * 300, 274 + row * 120);

                //截小图 判断牌子更精确
                var orc = upleft;
                orc.X += 79;
                //dm.delay(1000);
                //var count = dm.GetFindStr("牌子", "B19C85-040608", orc, downRight);
                //Console.WriteLine($"牌子:{5 - count}个");
                dm.delay(1000);
                var pos = dm.GetPositionByOcr("突破失败|突破失败2", "F5DB8F-08111A", orc, downRight);
                if (pos != null)
                {
                    Console.WriteLine($"挑战失败:{pos.X},{pos.Y}");
                }
                else
                {
                    orc.X += 40;
                    orc.Y += 40;
                    dm.MoveToClick(orc);
                    var attackBtn = Features.AttackBtn;
                    attackBtn.Dir = 3;
                    attackBtn.UpleftPosition = new Position(orc.X + 40, orc.Y);
                    attackBtn.LowRightPosition = new Position(downRight.X, downRight.Y + 72);
                    dm.delay(1000);
                    //Capture(dm, attackBtn.UpleftPosition, attackBtn.LowRightPosition);
                    var model = dm.WhileFeatures(() => dm.ColorsFunc(attackBtn), "点击进攻");
                    if (model != null)
                    {
                        Console.WriteLine($"进攻按钮:{model.X},{model.Y}");
                        dm.delay(1500);
                        dm.MoveToClick(model);
                        dm.delay(5000);
                        //战斗开始
                        //循环检测准备按钮
                        model = dm.WhileFeatures(() => dm.ColorsFunc(Features.Prepare), "战斗准备");
                        if (model != null)
                        {
                            Console.WriteLine($"准备:{model.X},{model.Y}");

                            Ready:
                            dm.delay(3000);
                            dm.MoveToClick(new Position(1111, 518));
                            //循环检测战斗是否结束
                            var attackIng = 0;
                            var isNotOk = true;
                            while (isNotOk)
                            {
                                Console.WriteLine("战斗检测中...");
                                dm.delay(200);
                                //失败
                                pos = dm.GetPositionByOcr("战斗失败", "4B607C-030304", new Position(550, 550), new Position(585, 5982));
                                if (pos == null)
                                {
                                    dm.delay(200);
                                    //胜利
                                    pos = dm.GetPositionByOcr("战斗结束", "7E9DA7-5E5556", new Position(415, 525),
                                        new Position(449, 566));
                                    if (pos == null)
                                    {
                                        if (attackIng > 500)
                                        {
                                            goto Ready;
                                        }
                                        attackIng++;
                                        continue;
                                    }
                                }
                                Console.WriteLine("战斗结束");
                                dm.delay(500);
                                dm.MoveToClick(pos);
                                isNotOk = false;
                                col = 0;
                                row = 0;
                                dm.delay(2000);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("寮突破次数结束!");
                        l.Y += 163;
                        if (l.Y > 600)
                        {
                            l.Y = 175;
                        }
                        goto Start;
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
            Finish:
            Console.WriteLine("结界突破结束!");
        }


        public static void Capture(XGDm dm, Position upleft, Position downRight)
        {
            var time = DateTime.Now.ToString("hh-mm-ss");
            var picPath = $"{AppDomain.CurrentDomain.BaseDirectory}test{time}.bmp";
            Console.WriteLine(picPath);
            dm.Capture(upleft.X, upleft.Y, downRight.X, downRight.Y, picPath);
        }
    }
}