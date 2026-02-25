using System.Collections.Generic;

namespace Dave6.Foundation.Collections
{
    // 영역 타입
    public readonly struct GridRect
    {
        public readonly GridCoord min;      // 영역의 최소 좌표
        public readonly GridCoord size;

        public int width => size.x;
        public int height => size.y;

        public GridRect(GridCoord min, GridCoord size)
        {
            this.min = min;
            this.size = size;
        }

        public bool Contains(GridCoord coord)
        {
            return coord.x >= min.x && coord.x < min.x + size.x && coord.y >= min.y && coord.y < min.y + size.y;
        }

        public IEnumerable<GridCoord> Cells()
        {
            for (int y = min.y; y < min.y + size.y; y++)
            for (int x = min.x; x < min.x + size.x; x++)
                yield return new GridCoord(x, y);
        }
    }
}