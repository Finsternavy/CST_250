using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        public int size { get; set; }

        public Cell[,] theGrid;

        public int nextRow = 0;
        public int nextColumn = 0;

        public Board(int size)
        {
            this.size = size;

            theGrid = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void markNextLegalMoves(Cell currentCell, string chessPiece)
        {
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    theGrid[row, column].legalNextMove = false;
                    theGrid[row, column].currentlyOccupied = false;
                }
            }

            

            switch (chessPiece)
            {
                case "Knight":

                    theGrid[currentCell.rowNumber, currentCell.columnNumber].currentlyOccupied = true;

                    // two spaces up and one to the left
                    if (validateOffset(currentCell, -2, -1))
                        theGrid[currentCell.rowNumber - 2, currentCell.columnNumber - 1].legalNextMove = true;
                    
                    // two spaces up and one to the right
                    if(validateOffset(currentCell, -2, 1))
                        theGrid[currentCell.rowNumber - 2, currentCell.columnNumber + 1].legalNextMove = true;

                    // one space up and two spaces right
                    if(validateOffset(currentCell, -1, 2))
                        theGrid[currentCell.rowNumber - 1, currentCell.columnNumber + 2].legalNextMove = true;

                    // one space down and two spaces right
                    if(validateOffset(currentCell, 1, 2))
                        theGrid[currentCell.rowNumber + 1, currentCell.columnNumber + 2].legalNextMove = true;

                    // two spaces down and one space right
                    if(validateOffset(currentCell, 2, 1))
                        theGrid[currentCell.rowNumber + 2, currentCell.columnNumber + 1].legalNextMove = true;

                    // two spaces down and one space left
                    if(validateOffset(currentCell, 2, -1))
                        theGrid[currentCell.rowNumber + 2, currentCell.columnNumber - 1].legalNextMove = true;

                    // one space down and two spaces left
                    if(validateOffset(currentCell, 1, -2))
                        theGrid[currentCell.rowNumber + 1, currentCell.columnNumber - 2].legalNextMove = true;

                    // one space up and two spaces left
                    if(validateOffset(currentCell, -1, -2))
                    theGrid[currentCell.rowNumber - 1, currentCell.columnNumber - 2].legalNextMove = true;
                    break;

                case "King":

                    theGrid[currentCell.rowNumber, currentCell.columnNumber].currentlyOccupied = true;

                    // one space up and one space left
                    if (validateOffset(currentCell, -1, -1))
                        theGrid[currentCell.rowNumber - 1, currentCell.columnNumber - 1].legalNextMove = true;

                    // one space up 
                    if (validateOffset(currentCell, -1, 0))
                        theGrid[currentCell.rowNumber - 1, currentCell.columnNumber].legalNextMove = true;

                    // one space up and one space right
                    if (validateOffset(currentCell, -1, 1))
                        theGrid[currentCell.rowNumber - 1, currentCell.columnNumber + 1].legalNextMove = true;

                    // one space right
                    if (validateOffset(currentCell, 0, 1))
                        theGrid[currentCell.rowNumber, currentCell.columnNumber + 1].legalNextMove = true;

                    // one space down and one space right
                    if (validateOffset(currentCell, 1, 1))
                        theGrid[currentCell.rowNumber + 1, currentCell.columnNumber + 1].legalNextMove = true;

                    // one space down
                    if (validateOffset(currentCell, 1, 0))
                        theGrid[currentCell.rowNumber + 1, currentCell.columnNumber].legalNextMove = true;

                    // one space down and one space left
                    if (validateOffset(currentCell, 1, -1))
                        theGrid[currentCell.rowNumber + 1, currentCell.columnNumber - 1].legalNextMove = true;

                    // one space left
                    if (validateOffset(currentCell, 0, -1))
                        theGrid[currentCell.rowNumber, currentCell.columnNumber - 1].legalNextMove = true;

                    break;

                case "Rook":

                    theGrid[currentCell.rowNumber, currentCell.columnNumber].currentlyOccupied = true;

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check diagonal up and left
                    while ( validateOffset(currentCell, nextRow - 1, nextColumn - 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow - 1, currentCell.columnNumber + nextColumn - 1].legalNextMove = true;
                        nextRow--;
                        nextColumn--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check diagonal up and right
                    while (validateOffset(currentCell, nextRow - 1, nextColumn + 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow - 1, currentCell.columnNumber + nextColumn + 1].legalNextMove = true;
                        nextRow--;
                        nextColumn++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check diagonal down and right
                    while (validateOffset(currentCell, nextRow + 1, nextColumn + 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow + 1, currentCell.columnNumber + nextColumn + 1].legalNextMove = true;
                        nextRow++;
                        nextColumn++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check diagonal down and left
                    while (validateOffset(currentCell, nextRow + 1, nextColumn - 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow + 1, currentCell.columnNumber + nextColumn - 1].legalNextMove = true;
                        nextRow++;
                        nextColumn--;
                    }

                    break;

                case "Bishop":

                    theGrid[currentCell.rowNumber, currentCell.columnNumber].currentlyOccupied = true;

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check left
                    while (validateOffset(currentCell, nextRow, nextColumn - 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow, currentCell.columnNumber + nextColumn - 1].legalNextMove = true;
                        nextColumn--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check up
                    while (validateOffset(currentCell, nextRow - 1, nextColumn))
                    {
                        theGrid[currentCell.rowNumber + nextRow - 1, currentCell.columnNumber + nextColumn].legalNextMove = true;
                        nextRow--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check right
                    while (validateOffset(currentCell, nextRow, nextColumn + 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow, currentCell.columnNumber + nextColumn + 1].legalNextMove = true;
                        nextColumn++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // check down
                    while (validateOffset(currentCell, nextRow + 1, nextColumn))
                    {
                        theGrid[currentCell.rowNumber + nextRow + 1, currentCell.columnNumber + nextColumn].legalNextMove = true;
                        nextRow++;
                    }

                    break;

                case "Queen":

                    theGrid[currentCell.rowNumber, currentCell.columnNumber].currentlyOccupied = true;

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // left
                    while (validateOffset(currentCell, nextRow, nextColumn - 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow, currentCell.columnNumber + nextColumn - 1].legalNextMove = true;
                        nextColumn--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // up and to the left
                    while (validateOffset(currentCell, nextRow - 1, nextColumn - 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow - 1, currentCell.columnNumber + nextColumn - 1].legalNextMove = true;
                        nextRow--;
                        nextColumn--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // up
                    while (validateOffset(currentCell, nextRow - 1, nextColumn))
                    {
                        theGrid[currentCell.rowNumber + nextRow - 1, currentCell.columnNumber + nextColumn].legalNextMove = true;
                        nextRow--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // up and to the right
                    while (validateOffset(currentCell, nextRow - 1, nextColumn + 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow - 1, currentCell.columnNumber + nextColumn + 1].legalNextMove = true;
                        nextRow--;
                        nextColumn++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;


                    // right
                    while (validateOffset(currentCell, nextRow, nextColumn + 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow, currentCell.columnNumber + nextColumn + 1].legalNextMove = true;
                        nextColumn++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // down and to the right
                    while (validateOffset(currentCell, nextRow + 1, nextColumn + 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow + 1, currentCell.columnNumber + nextColumn + 1].legalNextMove = true;
                        nextRow++;
                        nextColumn++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // down
                    while (validateOffset(currentCell, nextRow + 1, nextColumn))
                    {
                        theGrid[currentCell.rowNumber + nextRow + 1, currentCell.columnNumber + nextColumn].legalNextMove = true;
                        nextRow++;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    // down and left
                    while (validateOffset(currentCell, nextRow + 1, nextColumn - 1))
                    {
                        theGrid[currentCell.rowNumber + nextRow + 1, currentCell.columnNumber + nextColumn - 1].legalNextMove = true;
                        nextRow++;
                        nextColumn--;
                    }

                    // reset values to current offsets to zero
                    nextRow = 0;
                    nextColumn = 0;

                    break;

                default:

                    break;
            }
        }

        // Verify proposed move is not out of bounds
        private bool validateOffset(Cell currentCell, int rowOffset, int columnOffset)
        {
            if((currentCell.rowNumber + rowOffset < 0 || currentCell.rowNumber + rowOffset > size - 1) || (currentCell.columnNumber + columnOffset < 0 || currentCell.columnNumber + columnOffset > size - 1)){
                return false;
            }

            return true;
        }
    }
}
