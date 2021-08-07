using Minesweeper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperGUI
{
    public partial class Form1 : Form
    {
        static public Board myBoard;
        public Button[,] buttonGrid;
        Form myGameBoardForm;
        
        public Form1(Form gameBoardForm)
        {
            myGameBoardForm = gameBoardForm;
            gameBoardForm.Width = 720;
            gameBoardForm.Height = 720;
            InitializeComponent();
            
            //gamePanel.Hide();
        }

        public void populateGrid()
        {
            int buttonSize = startPanel.Width / myBoard.getSize();
            startPanel.Height = startPanel.Width;

            for (int row = 0; row < myBoard.getSize(); row++)
            {
                for (int column = 0; column < myBoard.getSize(); column++)
                {
                    buttonGrid[row, column] = new Button();

                    buttonGrid[row, column].Width = buttonSize;
                    buttonGrid[row, column].Height = buttonSize;

                    buttonGrid[row, column].Click += Grid_Button_Click;
                    myGameBoardForm.Controls.Add(buttonGrid[row, column]);
                    buttonGrid[row, column].Location = new Point(buttonSize * row, buttonSize * column);

                    //buttonGrid[row, column].Text = row.ToString() + "|" + column.ToString();

                    buttonGrid[row, column].Tag = row.ToString() + "|" + column.ToString();
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            string[] stringArray = (sender as Button).Tag.ToString().Split('|');
            int row = int.Parse(stringArray[0]);
            int column = int.Parse(stringArray[1]);

            Cell currentCell = myBoard.grid[row, column];
            //updateButtonLabels();

            for (int i = 0; i < myBoard.getSize(); i++)
            {
                for (int j = 0; j < myBoard.getSize(); j++)
                {
                    buttonGrid[i, j].BackColor = default(Color);
                }
            }
            (sender as Button).Text = "1";
           
        }
        private void playGameButton_Click(object sender, EventArgs e)
        {
            

            if (easyRadioButton.Checked == true)
            {
                myBoard = new Board(12, 15);
                buttonGrid = new Button[myBoard.getSize(), myBoard.getSize()];

            }
            else if(moderateRadioButton.Checked == true)
            {
                myBoard = new Board(20, 20);
                buttonGrid = new Button[myBoard.getSize(), myBoard.getSize()];
            }
            else
            {
                myBoard = new Board(30, 25);
                buttonGrid = new Button[myBoard.getSize(), myBoard.getSize()];
            }

            populateGrid();

            //myGameBoardForm.Update();
            myGameBoardForm.Show();
            this.Hide();



            
        }
    }
}
