namespace Dave6.Foundation.Collections
{
    public class Grid2D<T>
    {
        public readonly int width;
        public readonly int height;
        readonly T[,] cells;

        public Grid2D(int width, int height)
        {
            this.width = width;
            this.height = height;
            cells = new T[width, height];
        }

        #region 접근
        /// <summary>
        /// 좌표가 Grid 영역 내부인지 확인
        /// </summary>
        public bool IsInside(GridCoord coord)
        {
            return coord.x >= 0 && coord.x < width && coord.y >= 0 && coord.y < height;
        }
        public bool TryGetCell(GridCoord coord, out T value)
        {
            if (!IsInside(coord))
            {
                value = default;
                return false;
            }

            value = cells[coord.x, coord.y];
            return true;
        }

        public void SetCell(GridCoord coord, T value)
        {
            if (!IsInside(coord)) return;
            cells[coord.x, coord.y] = value;
        }
        public void SetCellRect(GridRect rect, T value)
        {
            foreach (var coord in rect.Cells())
            {
                SetCell(coord, value);
            }
        }
        public void ClearCell(GridCoord coord)
        {
            if (!IsInside(coord)) return;
            cells[coord.x, coord.y] = default;
        }
        public void ClearCellRect(GridRect rect)
        {
            foreach (var coord in rect.Cells())
            {
                ClearCell(coord);
            }
        }
        #endregion
    }
}