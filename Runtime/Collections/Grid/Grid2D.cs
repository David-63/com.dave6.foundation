namespace Dave6.Foundation.Collections
{
    public class Grid2D<T>
    {
        public readonly int Width;
        public readonly int Height;
        readonly T[,] _Cells;

        public Grid2D(int width, int height)
        {
            Width = width;
            Height = height;
            _Cells = new T[width, height];
        }

        #region 접근
        /// <summary>
        /// 좌표가 Grid 영역 내부인지 확인
        /// </summary>
        public bool IsInside(GridCoord coord)
        {
            return coord.X >= 0 && coord.X < Width && coord.Y >= 0 && coord.Y < Height;
        }
        public bool TryGetCell(GridCoord coord, out T value)
        {
            if (!IsInside(coord))
            {
                value = default;
                return false;
            }

            value = _Cells[coord.X, coord.Y];
            return true;
        }

        public void SetCell(GridCoord coord, T value)
        {
            if (!IsInside(coord)) return;
            _Cells[coord.X, coord.Y] = value;
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
            _Cells[coord.X, coord.Y] = default;
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