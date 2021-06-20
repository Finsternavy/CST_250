using System;

namespace Minesweeper
{
    class Program
    {
        public static void printBoard(Board board)
        {
            int size = board.getSize();

            // Print header
            for (int count = 0; count < size; count++)
            {
                // Spacing changes when number of digits change. If row # below ten, a space is needed after the count to keep alignment
                if (count < 10) Console.Write("+ " + count + " ");

                // Remove extra space after count to maintain alignment with single digit row numbers
                else Console.Write("+ " + count);
            }

            // Add end of border before moving on to next row
            Console.Write("+\r\n");

            // Print grid with row count at the end and borders
            for (int row = 0; row < size; row++)
            {
                // Print boarder above each row
                for (int count = 0; count < size; count++)
                {
                    Console.Write("+---");
                }
                // end the border with a +
                Console.Write("+\r\n");

                // Print for each cell in the row
                for (int column = 0; column < size; column++)
                {
                    // Check to see if the current cell is live.  If not, print the live neighbor count
                    if (board.grid[row, column].getLive() == false)
                        // Print cell left border and cells live neighbor count
                        Console.Write("| " + board.grid[row, column].getLiveNeighbors() + " ");
                    // Print the left cell border and if the cell is live, print an asteric insead of the live neighbor count
                    else Console.Write("| * ");
                }

                //Print row end border and row number before moving on to the next row
                Console.Write("| " + row + "\r\n");
            }

            // Print bottom border
            for (int count = 0; count < size; count++)
            {
                Console.Write("+---");
            }
            // end the border with a +
            Console.Write("+\r\n");

        }
        static void Main(string[] args)
        {
            // Create instance of the board class
            Board board = new Board((12));
            // Added to allow adjustments of difficulty to a level that makes sense.
            board.setDifficulty(15);
            board.setupLiveNeighbors();
            board.calculateLiveNeighbors();

            printBoard(board);
        }
    }
}
