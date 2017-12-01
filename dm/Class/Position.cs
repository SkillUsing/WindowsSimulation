namespace dm
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position()
        {
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static class PositionEx
    {
        public static Position OffsetPosition(this Position pos, Position offsetPos)
        {
            pos.X = pos.X + offsetPos.X;
            pos.Y = pos.Y + offsetPos.Y;
            return pos;
        }
    }
}