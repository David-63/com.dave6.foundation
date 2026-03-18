using Dave6.Foundation.Math;

namespace Dave6.Foundation.Collections
{
    // 좌표 타입
    public readonly struct GridCoord
    {
        private readonly Int2 _Value;
        public int X => _Value.X;
        public int Y => _Value.Y;

        public GridCoord(int x, int y)
        {
            _Value = new Int2(x, y);
        }
        public GridCoord(Int2 value)
        {
            _Value = value;
        }
        public override string ToString() => $"({X}, {Y})";
    }
}