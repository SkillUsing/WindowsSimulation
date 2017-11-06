namespace dm
{
    public class Features
    {
        //区域左上坐标
        public Position UpleftPosition { get; set; }

        //区域右下坐标
        public Position LowRightPosition { get; set; }

        //偏移坐标
        public Position OffsetPosition { get; set; }

        //颜色格式
        public string FirstColor { get; set; }

        //偏移颜色
        public string OffsetColor { get; set; }

        public double Sim { get; set; }

        public int Dir { get; set; }

    }
}