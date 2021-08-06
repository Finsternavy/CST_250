using ChessBoardModel;
using System;

namespace ChessBoardConsoleApp
{
    class Program
    {

        static Board myBoard = new Board(8);

        static public void printGrid(Board myBoard)
        {
            // print the board on the console. Use "X" for the current location, "+" for the legal moves and "." for an empty square

            
            
            for (int i = 0; i < myBoard.size; i++)
            {
                for (int k = 0; k < myBoard.size; k++)
                {
                    Console.Write("+---");
                }

                Console.Write("+");
                Console.WriteLine();

                for (int j = 0; j < myBoard.size; j++)
                {
                    Console.Write("| ");

                    if(myBoard.theGrid[i, j].currentlyOccupied)
                    {
                        Console.Write("X ");
                    }
                    else if(myBoard.theGrid[i, j].legalNextMove)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }

                }

                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("==================================");
        }

        static public Cell setCurrentCell()
        {
            int currentRow = getUserRowInput();
            int currentColumn = getUserColumnInput();

            myBoard.theGrid[currentRow, currentColumn].currentlyOccupied = true;

            return myBoard.theGrid[currentRow, currentColumn];
        }

        static public int getUserRowInput()
        {
            int currentRow;
            
            Console.Out.Write("Enter your current row number ");

            if (int.TryParse(Console.ReadLine(), out currentRow) && currentRow < myBoard.size)
            {
                return currentRow;
            }

            return getUserRowInput(); 
        }

        static public int getUserColumnInput()
        {
            int currentColumn;

            Console.Out.Write("Enter your current column number ");

            if (int.TryParse(Console.ReadLine(), out currentColumn) && currentColumn < myBoard.size)
            {
                return currentColumn;
            }

            return getUserColumnInput();
        }

        static public string getDesiredPieceToMove()
        {
            Console.Out.Write("What piece do you want to move?  Knight, King, Rook, Bishop or Queen? (Case sensitive! Typo's will result in no moves being displayed.)");
            string choice = Console.ReadLine();

            return choice;
        }
        static void Main(string[] args)
        {
            // show the empty chessboard
            printGrid(myBoard);

            // get the location of the chess piece
            Cell myLocation = setCurrentCell();

            Console.Out.Write("What piece do you want to move?  Knight, King, Rook, Bishop or Queen?");
            // calculate and mark the cells where legal moves are possible
            myBoard.markNextLegalMoves(myLocation, getDesiredPieceToMove());

            // show the chess board. Use . for an empty square, X for the piece location and + for a possible legal move
            printGrid(myBoard);

            // wait for another return key to end the program
            Console.ReadLine();
        }
    }
}
