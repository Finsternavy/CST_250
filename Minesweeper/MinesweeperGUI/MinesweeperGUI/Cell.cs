using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper
{
    public class Cell
    {
        private int row = -1;
        private int column = -1;
        private int liveNeighbors = 0;
        private bool visited = false;
        private bool live = false;

        // Cell constructor initializes cell row and column number
        public Cell(int row, int column){
            this.row = row;
            this.column = column;
        }

        // Getters and setters
        // Set this cells row value
        public void setRow(int row)
        {
            this.row = row;
        }

        // return this cells row value
        public int getRow()
        {
            return this.row;
        }

        // Set this cells column value
        public void setColumn(int column)
        {
            this.column = column;
        }

        // return this cell's column value
        public int getColumn()
        {
            return this.column;
        }

        // Set this cell's visited value
        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        // Return this cell's visted value
        public bool getVisited()
        {
            return this.visited;
        }

        // Set this cell's live value
        public void setLive(bool live)
        {
            this.live = live;
        }

        // Return this cell's live value
        public bool getLive()
        {
            return this.live;
        }

        // Set this cell's liveNeighbors value
        public void setLiveNeighbors(int liveNeighbors)
        {
            this.liveNeighbors = liveNeighbors;
        }

        // Return this cell's liveNeighbor value
        public int getLiveNeighbors()
        {
            return this.liveNeighbors;
        }
    }
}
