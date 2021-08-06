using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Cell
    {
        public int rowNumber { get; set; }
        public int columnNumber { get; set; }
        public bool currentlyOccupied { get; set; }
        public bool legalNextMove { get; set; }

        public Cell(int row, int column)
        {
            this.rowNumber = row;
            this.columnNumber = column;
        }
    }
}
