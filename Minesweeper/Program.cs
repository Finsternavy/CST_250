using System;

namespace Minesweeper
{
    class Program
    {
        public static bool gameOver { get; set; }
        static Cell currentCell;
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
                    /*// Check to see if the current cell is live.  If not, print the live neighbor count
                    if (board.grid[row, column].getLive() == false)
                        // Print cell left border and cells live neighbor count
                        Console.Write("| " + board.grid[row, column].getLiveNeighbors() + " ");
                    // Print the left cell border and if the cell is live, print an asteric insead of the live neighbor count
                    else Console.Write("| * ");*/

                    Console.Write("| ? ");
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

        public static void printBoardDuringGame(Board board)
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
                    // if cell has not been visited print a ? in the middle
                    if (board.grid[row, column].getVisited() == false)
                    {
                        Console.Write("| ? ");
                    }
                    // if the cell has been visited and is a bomb print * in the middle
                    else if(board.grid[row, column].getLive() == true)
                    {
                        Console.Write("| * ");
                    }
                    // if the the cell has been visited and is not a bomb and has no live neighbors print nothing in the cell
                    else if(board.grid[row, column].getLiveNeighbors() == 0)
                    {
                        Console.Write("|   ");
                    }
                    // if the cell has been visited, is not a bomb, and has live neighbors, print the number of live neighbors in the middle
                    else
                    {
                        Console.Write("| {0} ", board.grid[row, column].getLiveNeighbors().ToString());
                    }
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
        public static int requestValidInput_Row(Board board)
        {
            // hold the parsed value of the user input
            int input;

            Console.Out.WriteLine("Please select a row ");

            // if the user input is parsable to an int and not out of bounds
            if (int.TryParse(Console.ReadLine(), out input) && input < board.getSize())
            {
                return input;
            }

            // if input is not valid, ask for it again
            return requestValidInput_Row(board);
        }

        // same concept as requestValidInput_Row()
        public static int requestValidInput_Column(Board board)
        {
            int input;

            Console.Out.WriteLine("Please select a column ");

            if (int.TryParse(Console.ReadLine(), out input) && input < board.getSize())
            {
                return input;
            }

            return requestValidInput_Column(board);
        }

        // check If all cells that are not live have been visited, if so game is won
        public static void checkIfGameWon(Board board)
        {
            int notLiveLeftCount = 0;

            for (int row = 0; row < board.getSize(); row++)
            {
                for (int column = 0; column < board.getSize(); column++)
                {
                    // increment notLiveLeftCount if a cell is not a bomb and has not been visited
                    if(board.grid[row, column].getVisited() == false && board.grid[row, column].getLive() == false)
                    {
                        notLiveLeftCount++;
                    }
                }
            }

            // if there are no cells left that are not bombs, the game is won
            if(notLiveLeftCount == 0) 
            {
                // Display the final board
                printBoardDuringGame(board);
                Console.WriteLine("You avoided all the bombs! Great job!");
                gameOver = true;
            }
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

            // game loop.  While game is not over, keep asking for input
            while (gameOver == false)
            {
                // get user input for row and column to select and store in variable
                int userInputRow = requestValidInput_Row(board);
                int userInputColumn = requestValidInput_Column(board);

                // check if user selected cell is a bomb
                if(board.grid[userInputRow, userInputColumn].getLive() == true)
                {
                    gameOver = true;
                    board.grid[userInputRow, userInputColumn].setVisited(true);
                    printBoardDuringGame(board);
                    Console.WriteLine("That cell was live! Game over!");
                    return;
                }

                // if user selected cell is not a bomb...

                // set selected cell as visited
                board.grid[userInputRow, userInputColumn].setVisited(true);

                if(board.grid[userInputRow, userInputColumn].getLiveNeighbors() == 0)
                {
                    board.floodFill(userInputRow, userInputColumn);
                }
                // print the updated board to the user
                printBoardDuringGame(board);
                // display to the user the results of there last selection
                Console.WriteLine("That cell has {0} live neightbors. Keep going!", board.grid[userInputRow, userInputColumn].getLiveNeighbors());
                
            }
        }
    }
}
