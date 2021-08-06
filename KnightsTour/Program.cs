using System;

namespace KnightsTour
{
    class Program
    {
        static int boardSize = 8;
        static int attemptedMoves = 0;
        /* xMove[] and yMove[] define next move of Knight.
         * xMove[] is for next value of x coordinate
         * yMove[] is for next value of y coordinate */
        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        // boardGrid is an 8x8 array that contains -1 for an unvisited square or a move number between 0 and 63
        static int[,] boardGrid = new int[boardSize, boardSize];

        static void Main(string[] args)
        {
            solveKT();
            Console.ReadLine();
        }

        /*This function solves the Knight Tour problem using backtracking.  This function uses solveKTUTIL() to solve the problem. It returns false if no complete tour is possible, otherwise return true and prints the tour.
         * Please note that there may be more than one solution */
        static void solveKT()
        {
            // Initialization of solution matrix.  value of -1 means "not visited yet"
            for (int x = 0; x < boardSize; x++)
                for (int y = 0; y < boardSize; y++)
                    boardGrid[x, y] = -1;
            int startX = 0;
            int startY = 4;
            // set starting position for knight
            boardGrid[startX, startY] = 0;

            // count the total number of guesses
            attemptedMoves = 0;

            // explore all tours using solveKTUTIL()
            if (!solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0} {1}", startX, startY);
            }
            else
            {
                printSolution(boardGrid);
                Console.Out.WriteLine("Total attempted moves {0}", attemptedMoves);
            }


        }

        // a recursive utility function to solve knight tour problem
        static bool solveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0) Console.Out.WriteLine("Attempts: {0}", attemptedMoves);

            int k, next_x, next_y;

            // check to see if we have reached a solution.  64 = moveCount
            if (moveCount == boardSize * boardSize)
                return true;

            // Try all next moves from the current coordinate x, y
            for (k = 0; k < 8; k++)
            {
                next_x = x + xMove[k];
                next_y = y + yMove[k];
                if(isSquareSafe(next_x, next_y))
                {
                    boardGrid[next_x, next_y] = moveCount;
                    if (solveKTUtil(next_x, next_y, moveCount + 1))
                        return true;
                    else
                        // backtracking
                        boardGrid[next_x, next_y] = -1;
                }
            }
            return false;
        }

        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < boardSize && y >= 0 & y < boardSize && boardGrid[x, y] == -1);
        }

        static void printSolution(int[,] solution)
        {
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                    Console.Write(solution[x, y] + " ");

                Console.WriteLine();
            }
        }
    }
}
