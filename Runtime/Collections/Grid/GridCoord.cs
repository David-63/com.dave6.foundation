namespace Dave6.Foundation.Collections
{
    // 좌표 타입
    public readonly struct GridCoord
    {
        public readonly int x;
        public readonly int y;

        public GridCoord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString() => $"({x}, {y})";
    }
}