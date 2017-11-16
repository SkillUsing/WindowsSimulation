namespace dm
{
    public class Features
    {
        //区域左上坐标
        public Position UpleftPosition { get; set; }

        //区域右下坐标
        public Position LowRightPosition { get; set; }

        //颜色格式
        public string FirstColor { get; set; }

        //偏移颜色
        public string OffsetColor { get; set; }

        public double Sim { get; set; } = 0.9;

        public int Dir { get; set; } = 0;


        /// <summary>
        /// 战斗失败
        /// </summary>
        public static Features Errors = new Features()
        {
            UpleftPosition = new Position(550, 550),
            LowRightPosition = new Position(585, 5982),
            FirstColor = "4B607C-030304"
        };

        /// <summary>
        /// 找灯笼
        /// dir=0 是探索
        /// dir=1 是召唤
        /// </summary>
        public static Features Explore = new Features()
        {
            UpleftPosition = new Position(413, 101),

            LowRightPosition = new Position(1065, 148),

            FirstColor = "ffffcd",

            OffsetColor = "15|-1|ffffbe,-12|3|ffe4a6,3|5|ffffda,22|4|fde4a6"
        };


        /// <summary>
        /// 返回按钮
        /// </summary>
        public static Features ReturnBtn = new Features()
        {
            UpleftPosition = new Position(16, 21),

            LowRightPosition = new Position(98, 98),

            FirstColor = "f0f5fb",

            OffsetColor = "-9|15|1d122f,-1|-22|210d4f,38|9|1a1f50"
        };


        /// <summary>
        /// 查找结界突破
        /// </summary>
        public static Features SelectBreakthrough = new Features()
        {
            UpleftPosition = new Position(329, 550),

            LowRightPosition = new Position(418, 634),

            FirstColor = "331f2b",

            OffsetColor = "49|-3|312021,3|12|f4efdc,42|7|f0ebd8,25|26|5091e5"
        };

        /// <summary>
        /// 是否进入结界突破
        /// </summary>
        public static Features IsBreakthrough = new Features()
        {
            UpleftPosition = new Position(1016, 32),

            LowRightPosition = new Position(1089, 100),

            FirstColor = "e8d4cf",

            OffsetColor = "-6|2|ba2f57,8|2|8e3361,1|14|753743"
        };


        /// <summary>
        ///准备
        /// </summary>
        public static Features Prepare = new Features()
        {
            UpleftPosition = new Position(1102, 497),

            LowRightPosition = new Position(1229, 607),

            FirstColor = "fff1cd",

            OffsetColor = "0|1|fff1cd"
        };


        /// <summary>
        /// 准备2
        /// </summary>
        public static Features PreparesFeatures = new Features()
        {
            UpleftPosition = new Position(1113, 498),

            LowRightPosition = new Position(1221, 609),

            FirstColor = "fffaec",

            OffsetColor = "0|1|fffaec"
        };

        /// <summary>
        /// 胜利
        /// </summary>
        public static Features Victory = new Features()
        {
            UpleftPosition = new Position(478, 183),

            LowRightPosition = new Position(486, 192),

            FirstColor = "cfc1ac",

            OffsetColor = "7|0|cdbda9,0|8|cfc0ac,7|8|cebea9"
        };

        /// <summary>
        /// 失败
        /// </summary>
        public static Features Fail = new Features()
        {
            UpleftPosition = new Position(464, 150),

            LowRightPosition = new Position(477, 162),

            FirstColor = "514a5b",

            OffsetColor = "10|2|524d5f,1|7|4c4454,9|8|4f4757"
        };

        /// <summary>
        /// 战斗结束
        /// </summary>
        public static Features BattleOver = new Features()
        {
            UpleftPosition = new Position(589, 42),

            LowRightPosition = new Position(601, 60),

            FirstColor = "5c4b3b",

            OffsetColor = "8|0|6c6357,2|6|f4eedc,9|6|f8f3e0"
        };

        /// <summary>
        /// 可攻击目标
        /// </summary>
        public static Features AttackTarget = new Features()
        {
            UpleftPosition = new Position(131, 92),

            LowRightPosition = new Position(306, 221),

            FirstColor = "d8c8b7",

            OffsetColor = "-31|-39|d2c2b1,32|1|d8c8b7,23|-36|d4c4b3"
        };


        /// <summary>
        /// 未失败
        /// </summary>
        public static Features NoFail = new Features()
        {
            UpleftPosition = new Position(455, 116),

            LowRightPosition = new Position(463, 172),

            FirstColor = "a5957d",

            OffsetColor = "0|10|a99880,1|26|bead95,-1|-3|a09077"
        };

        /// <summary>
        /// 攻击按钮
        /// </summary>
        public static Features AttackBtn = new Features()
        {
            UpleftPosition = new Position(408, 33),

            LowRightPosition = new Position(1030, 605),

            FirstColor = "f4b25f",

            OffsetColor = "56|3|f4b25f,-8|28|f4b25f,66|26|f4b25f"
        };

        /// <summary>
        /// 挑战卷不足
        /// </summary>
        public static Features NoChallengeScroll = new Features()
        {
            UpleftPosition = new Position(408, 607),

            LowRightPosition = new Position(436, 635),

            FirstColor = "7f766c",

            OffsetColor = "0|15|645d55,-5|7|4e4841,4|7|565048,-13|6|d5c6b5"
        };

        /// <summary>
        /// 刷新
        /// </summary>
        public static Features Refresh = new Features()
        {
            UpleftPosition = new Position(987, 536),

            LowRightPosition = new Position(1015, 551),

            FirstColor = "f4b25f",

            OffsetColor = "11|2|f4b25f,-2|7|f4b25f,10|9|f4b25f"
        };

        /// <summary>
        /// 确定按钮
        /// </summary>
        public static Features ConfirmBtn = new Features()
        {
            UpleftPosition = new Position(723, 411),

            LowRightPosition = new Position(793, 452),

            FirstColor = "5b4830",

            OffsetColor = "45|-1|302a23,4|19|493c2b,48|19|342d24,25|8|f4b25f"
        };

        /// <summary>
        /// 确定按钮2
        /// </summary>
        public static Features ConfirmBtns = new Features()
        {
            UpleftPosition = new Position(691, 392),

            LowRightPosition = new Position(820, 455),

            FirstColor = "f4b25f",

            OffsetColor = "0|1|f4b25f"
        };

        /// <summary>
        /// X按钮
        /// </summary>
        public static Features XBtn = new Features()
        {
            UpleftPosition = new Position(1167, 47),

            LowRightPosition = new Position(1207, 88),

            FirstColor = "e6d5d5",

            OffsetColor = "0|1|e6d5d5"
        };


        /// <summary>
        /// CZ_寮1
        /// </summary>
        public static Features CzL1 = new Features()
        {
            UpleftPosition = new Position(1071, 248),

            LowRightPosition = new Position(1120, 364),

            FirstColor = "583824",

            OffsetColor = "2|1|aca293,7|19|aca293,-7|22|a19484"
        };

        /// <summary>
        /// CZ_寮2
        /// </summary>
        public static Features CzL2 = new Features()
        {
            UpleftPosition = new Position(1071, 248),

            LowRightPosition = new Position(1120, 364),

            FirstColor = "c36e1e",

            OffsetColor = "-6|9|efdfc5,10|4|eee1c8,19|-10|814b1e"
        };


        /// <summary>
        /// XH_寮
        /// </summary>
        public static Features XhL = new Features()
        {
            UpleftPosition = new Position(277, 153),

            LowRightPosition = new Position(305, 231),

            FirstColor = "cac1b1",

            OffsetColor = "0|1|cac1b1,0|2|cac1b1"
        };

        /// <summary>
        /// 没有牌子
        /// </summary>
        public static Features NoLabel = new Features()
        {
            UpleftPosition = new Position(511, 221),

            LowRightPosition = new Position(545, 595),

            FirstColor = "B3A28D",

            OffsetColor = "-10|1|A79783"
        };

        /// <summary>
        /// 未失败2
        /// </summary>
        public static Features NoError2 = new Features()
        {
            UpleftPosition = new Position(690, 160),

            LowRightPosition = new Position(690, 221),

            FirstColor = "cbbaa1",

            OffsetColor = "0|1|cbbaa2"
        };

        /// <summary>
        /// 无可攻击对手
        /// </summary>
        public static Features NoRival = new Features()
        {
            UpleftPosition = new Position(483, 114),

            LowRightPosition = new Position(1148, 238),

            FirstColor = "6a6259",

            OffsetColor = "0|1|6a6259"
        };


        /// <summary>
        /// 投降
        /// </summary>
        public static Features Surrender = new Features()
        {
            UpleftPosition = new Position(17, 15),

            LowRightPosition = new Position(54, 53),

            FirstColor = "d5c4a2",

            OffsetColor = "0|1|d5c4a2"
        };
    }
}