using System;
using XGLib;

namespace dm
{

    public static class DmTools
    {
        public static string BasePath;

        /// <summary>
        /// 全局定义左上坐标
        /// </summary>
        public static Position UpleftPosition = new Position(0, 0);

        /// <summary>
        /// 全局定义右下坐标
        /// new Position(1136, 640);
        /// new Position(1920, 1080);
        /// </summary>
        public static Position LowRightPosition = new Position(1136, 640);


        /// <summary>
        /// 找有透明背景的图并点击
        /// </summary>
        /// <param name="dm">大漠对象</param>
        /// <param name="picName">图片名称，不带后缀</param>
        /// <param name="sim">相似度</param>
        /// <param name="dir">查找方向:
        ///  0: 从左到右,从上到下 
        ///  1: 从左到右,从下到上 
        ///  2: 从右到左,从上到下 
        ///  3: 从右到左, 从下到上
        /// </param>
        public static bool FindPicClick(this XGDm dm, string picName, int dir = 1, double sim = 0.7)
        {
            var path = $"{BasePath}{picName}.bmp";
            Console.WriteLine(path);
            var x = dm.FindPicE(UpleftPosition.X, UpleftPosition.Y, LowRightPosition.X, LowRightPosition.Y, path, "000000", sim, 1);
            var value = StringToPosition(x);
            if (value == null)
                return false;
            dm.MoveTo(value.X + 20, value.Y + 20);
            dm.delay(200);
            dm.LeftClick();
            return true;
        }


        /// <summary>
        /// 获得图片位置
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="picName"></param>
        /// <param name="dir"></param>
        /// <param name="sim"></param>
        /// <returns></returns>
        public static Position GetPositionByFindPic(this XGDm dm, string picName, int dir = 1, double sim = 0.8)
        {
            var x = dm.FindPicE(UpleftPosition.X, UpleftPosition.Y, LowRightPosition.X, LowRightPosition.Y,
                $"{BasePath}{picName}.bmp", "000000", sim, 1);
            return StringToPosition(x);
        }



        public static Position GetPositionByOcr(this XGDm dm, string fonts, string colors, Position upLeftPosition = null, Position lowRightPosition = null)
        {
            if (upLeftPosition == null)
            {
                upLeftPosition = UpleftPosition;
            }
            if (lowRightPosition == null)
            {
                lowRightPosition = LowRightPosition;
            }
            var x = dm.FindStrE(upLeftPosition.X, upLeftPosition.Y, lowRightPosition.X, lowRightPosition.Y, fonts,
                    colors, 0.7);
            return StringToPosition(x);
        }

        /// <summary>
        /// 移动并点击
        /// </summary>
        /// <param name="dm">大漠对象</param>
        /// <param name="pos">坐标</param>
        public static void MoveToClick(this XGDm dm, Position pos)
        {
            dm.MoveTo(pos.X, pos.Y);
            dm.delay(200);
            dm.LeftClick();
        }


        /// <summary>
        /// 多点找色
        /// </summary>
        /// <param name="dm">大漠对象</param>
        /// <param name="model">Features 对象</param>
        public static Position ColorsFunc(this XGDm dm, Features model)
        {
            if (model.UpleftPosition == null)
            {
                model.UpleftPosition = UpleftPosition;
            }
            if (model.LowRightPosition == null)
            {
                model.LowRightPosition = LowRightPosition;
            }
            var result = dm.FindMultiColor(model.UpleftPosition.X,
                                      model.UpleftPosition.Y,
                                      model.LowRightPosition.X,
                                      model.LowRightPosition.Y,
                                      model.FirstColor,
                                      model.OffsetColor,
                                      model.Sim,
                                      model.Dir,
                                      out int x,
                                      out int y);
            if (result == 1)
            {
                return new Position(x, y);
            }
            return null;
        }

        /// <summary>
        /// 根据大漠返回字符串分离出来可空坐标
        /// </summary>
        public static Position StringToPosition(string str)
        {
            try
            {
                var ary = str.Split('|');
                var x = int.Parse(ary[1]);
                var y = int.Parse(ary[2]);
                return x > 0 ? new Position(x, y) : null;
            }
            catch
            {
                return null;
            }
        }
    }
}