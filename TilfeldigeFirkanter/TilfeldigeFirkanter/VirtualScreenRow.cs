using System;

namespace TilfeldigeFirkanter
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;

        public VirtualScreenRow(int screenWidth)
        {
            _cells = new VirtualScreenCell[screenWidth];
            for (int i = 0; i < screenWidth; i++)
            {
                var cell = new VirtualScreenCell();
                _cells[i] = cell;
            }
        }

        public void AddBoxTopRow(int boxX, int boxWidth)
        {
            for (int i = boxX; i < _cells.Length; i++)
            {
                if (i == boxX)
                {
                    _cells[i].AddUpperLeftCorner();
                }
                if(i == _cells.Length)
                {
                    _cells[i].AddUpperRightCorner();
                }
                else
                {
                    _cells[i].AddHorizontal();
                }
            }
        }
        public void AddBoxBottomRow(int boxX, int boxWidth) { }
        public void AddBoxMiddleRow(int boxX, int boxWidth) { }

        public void Show()
        {
            foreach (var cell in _cells)
            {
                Console.Write(cell.GetCharacter());
            }
        }
    }
}