using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    class Board
    {
        private int size = 0;
        public Cell[,] grid;
        private int difficulty = 20;

        public Board(int size)
        {
            this.size = size;
            initializeGrid(this.size);
        }

        private void initializeGrid(int size)
        {
            this.grid = new Cell[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    grid[row, column] = new Cell(row, column);
                }
            }
        }

        public void setupLiveNeighbors()
        {
            Random random = new Random();
            int randomNumber = 0;

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    randomNumber = random.Next(0, 100);

                    if(randomNumber <= difficulty)
                    {
                        grid[row, column].setLive(true);
                    }
                }
            }
        }

        public void calculateLiveNeighbors()
        {
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    // Check cell to the left if it is not on the left edge (Not out of bounds)
                    if (column % size != 0)
                    {
                        // If the cell to the left is live, increment this cells liveNeighbor count
                        if(grid[row, column - 1].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check cell 1 space above and one space to the left if not the first row and not on the left edge (Not out of bounds)
                    if (column % size != 0 && row > 0)
                    {
                        // If the cell in the upper left corner of this cell is live, increment this cells liveNeighbor count
                        if(grid[row - 1, column - 1].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check cell 1 space above if not the first row (Not out of bounds)
                    if (row > 0)
                    {
                        // If the cell above is live, increment this cells liveNeighbor count
                        if(grid[row - 1, column].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check cell 1 space above and 1 space to the right if not the first row and not on the right edge
                    if (row > 0 && column % size != size - 1)
                    {
                        // If the cell 1 space above and 1 space to the right is live, increment this cells liveNeighbor count
                        if (grid[row - 1, column + 1].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check if cell to the right is live if it is not on the right edge
                    if (column % size != size - 1)
                    {
                        // If the cell to the right is live, increment this cells liveNeighbor count
                        if (grid[row, column + 1].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check if cell below and to the right is live if it is not the bottom row or on the right edge
                    if (row < size - 1 && column % size != size - 1)
                    {
                        // If the cell below and to the right is live, increment this cells liveNeighbor count
                        if (grid[row + 1, column + 1].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check if cell below is live if not in the bottom row
                    if (row < size - 1)
                    {
                        // If the cell below this cell is live, increment this cells liveNeighbor count
                        if (grid[row + 1, column].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // Check if cell below and to the left is live iff not on the bottom row or left edge
                    if (row < size - 1 && column % size != 0)
                    {
                        // If the cell below and to the left is live, increment this cells liveNeighbor count
                        if (grid[row + 1, column - 1].getLive() == true)
                        {
                            grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                        }
                    }
                    // If this cell is live, increment this cells liveNeighbor count
                    if (grid[row, column].getLive() == true)
                    {
                        grid[row, column].setLiveNeighbors(grid[row, column].getLiveNeighbors() + 1);
                    }
                }
            }
        }

        public void floodFill(int row, int column)
        {
            List<Cell> cellsForFloodFill = new List<Cell>();
            grid[row, column].setVisited(true);

            // Check cell to the left if it is not on the left edge (Not out of bounds)
            if (column % size != 0)
            {
                // If the cell to the left has no neighbors, call floodfill on that cell
                if (grid[row, column - 1].getVisited() == false && grid[row, column - 1].getLiveNeighbors() == 0)
                {
                    floodFill(row, column - 1);
                }
                // if the cell has live neighbors and is not live itself, set visited true
                else if(grid[row, column - 1].getLive() == false)
                {
                    grid[row, column - 1].setVisited(true);
                }
            }
            // Check cell 1 space above and one space to the left if not the first row and not on the left edge (Not out of bounds)
            if (column % size != 0 && row > 0)
            {
                // If the cell in the upper left corner of this cell  has no neighbors, call floodfill on that cell
                if (grid[row - 1, column - 1].getVisited() == false && grid[row - 1, column - 1].getLiveNeighbors() == 0)
                {
                    floodFill(row - 1, column -1);
                }
                else if (grid[row - 1, column - 1].getLive() == false)
                {
                    grid[row - 1, column - 1].setVisited(true);
                }
            }
            // Check cell 1 space above if not the first row (Not out of bounds)
            if (row > 0)
            {
                // If the cell above  has no neighbors, call floodfill on that cell
                if (grid[row - 1, column].getVisited() == false && grid[row - 1, column].getLiveNeighbors() == 0)
                {
                    floodFill(row - 1, column);
                }
                else if (grid[row - 1, column].getLive() == false)
                {
                    grid[row - 1, column].setVisited(true);
                }
            }
            // Check cell 1 space above and 1 space to the right if not the first row and not on the right edge
            if (row > 0 && column % size != size - 1)
            {
                // If the cell 1 space above and 1 space to the right  has no neighbors, call floodfill on that cell
                if (grid[row - 1, column + 1].getVisited() == false && grid[row - 1, column + 1].getLiveNeighbors() == 0)
                {
                    floodFill(row - 1, column + 1);
                }
                else if (grid[row - 1, column + 1].getLive() == false)
                {
                    grid[row - 1, column + 1].setVisited(true);
                }
            }
            // Check if cell to the right is live if it is not on the right edge
            if (column % size != size - 1)
            {
                // If the cell to the right  has no neighbors, call floodfill on that cell
                if (grid[row, column + 1].getVisited() == false && grid[row, column + 1].getLiveNeighbors() == 0)
                {
                    floodFill(row, column + 1);
                }
                else if (grid[row, column + 1].getLive() == false)
                {
                    grid[row, column + 1].setVisited(true);
                }
            }
            // Check if cell below and to the right is live if it is not the bottom row or on the right edge
            if (row < size - 1 && column % size != size - 1)
            {
                // If the cell below and to the right  has no neighbors, call floodfill on that cell
                if (grid[row + 1, column + 1].getVisited() == false && grid[row + 1, column + 1].getLiveNeighbors() == 0)
                {
                    floodFill(row + 1, column + 1);
                }
                else if (grid[row + 1, column + 1].getLive() == false)
                {
                    grid[row + 1, column + 1].setVisited(true);
                }
            }
            // Check if cell below is live if not in the bottom row
            if (row < size - 1)
            {
                // If the cell below this cell  has no neighbors, call floodfill on that cell
                if (grid[row + 1, column].getVisited() == false && grid[row + 1, column].getLiveNeighbors() == 0)
                {
                    floodFill(row + 1, column);
                }
                else if (grid[row + 1, column].getLive() == false)
                {
                    grid[row + 1, column].setVisited(true);
                }
            }
            // Check if cell below and to the left is live iff not on the bottom row or left edge
            if (row < size - 1 && column % size != 0)
            {
                // If the cell below and to the left  has no neighbors, call floodfill on that cell
                if (grid[row + 1, column - 1].getVisited() == false && grid[row + 1, column - 1].getLiveNeighbors() == 0)
                {
                    floodFill(row + 1, column - 1);
                }
                else if (grid[row + 1, column - 1].getLive() == false)
                {
                    grid[row + 1, column - 1].setVisited(true);
                }
            }
        }

        public void setSize(int size)
        {
            this.size = size;
        }

        public int getSize()
        {
            return this.size;
        }

        public void setDifficulty(int difficulty)
        {
            this.difficulty = difficulty;
        }

        public int getDifficulty()
        {
            return this.difficulty; 
        }
    }
}
