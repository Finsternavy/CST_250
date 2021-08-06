using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        static public Board myBoard = new Board(8);
        public Button[,] buttonGrid = new Button[myBoard.size, myBoard.size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid()
        {
            int buttonSize = panel1.Width / myBoard.size;
            panel1.Height = panel1.Width;

            for (int row = 0; row < myBoard.size; row++)
            {
                for(int column = 0; column < myBoard.size; column++)
                {
                    buttonGrid[row, column] = new Button();

                    buttonGrid[row, column].Width = buttonSize;
                    buttonGrid[row, column].Height = buttonSize;

                    buttonGrid[row, column].Click += Grid_Button_Click;
                    panel1.Controls.Add(buttonGrid[row, column]);
                    buttonGrid[row, column].Location = new Point(buttonSize * row, buttonSize * column);

                    buttonGrid[row, column].Text = row.ToString() + "|" + column.ToString();

                    buttonGrid[row, column].Tag = row.ToString() + "|" + column.ToString();
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            string[] stringArray = (sender as Button).Tag.ToString().Split('|');
            int row = int.Parse(stringArray[0]);
            int column = int.Parse(stringArray[1]);

            Cell currentCell = myBoard.theGrid[row, column];
            myBoard.markNextLegalMoves(currentCell, getSelectedPiece());
            updateButtonLabels();

            for (int i = 0; i < myBoard.size; i++)
            {
                for(int j = 0; j < myBoard.size; j++)
                {
                    buttonGrid[i, j].BackColor = default(Color);
                }
            }

            (sender as Button).BackColor = Color.Cornsilk;
        }

        public void updateButtonLabels()
        {
            for (int row = 0; row < myBoard.size; row++)
            {
                for(int column = 0; column < myBoard.size; column++)
                {
                    buttonGrid[row, column].Text = "";
                    if (myBoard.theGrid[row, column].currentlyOccupied) buttonGrid[row, column].Text = getSelectedPiece();
                    if (myBoard.theGrid[row, column].legalNextMove) buttonGrid[row, column].Text = "Legal";
                }
            }
        }

        public string getSelectedPiece()
        {
            return comboBox1.Text;
        }
    }
}
