using System;

namespace Dave6.Foundation.Math
{
    [Serializable]
    public struct Int2
    {
        public int X;
        public int Y;
        public Int2(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}