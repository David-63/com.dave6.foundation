using System;

namespace Dave6.Foundation.Math
{
    [Serializable]
    public struct Float2
    {
        public float X;
        public float Y;
        public Float2(float x, float y)
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