using System.Collections.Generic;

namespace Dave6.Foundation.Collections
{
    // 영역 타입
    public readonly struct GridRect
    {
        public readonly GridCoord Origin;      // 영역의 최소 좌표
        public readonly GridCoord Size;

        public int Width => Size.X;
        public int Height => Size.Y;

        public GridRect(GridCoord min, GridCoord size)
        {
            Origin = min;
            Size = size;
        }

        public bool Contains(GridCoord coord)
        {
            return coord.X >= Origin.X && coord.X < Origin.X + Size.X && coord.Y >= Origin.Y && coord.Y < Origin.Y + Size.Y;
        }

        public IEnumerable<GridCoord> Cells()
        {
            for (int y = Origin.Y; y < Origin.Y + Size.Y; y++)
            for (int x = Origin.X; x < Origin.X + Size.X; x++)
                yield return new GridCoord(x, y);
        }
    }
}