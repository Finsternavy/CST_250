using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper_GUI
{
    public partial class StartMenu : Form
    {
        public GameBoard gameBoard;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(easyRadioButton.Checked == true)
            {
                gameBoard.difficulty = "Easy";
                gameBoard.populateGrid(4);
                gameBoard.stopWatch.Start();
            }
            else if(mediumRadioButton.Checked == true)
            {
                gameBoard.difficulty = "Medium";
                gameBoard.populateGrid(18);
                gameBoard.stopWatch.Start();
            }
            else
            {
                gameBoard.difficulty = "Hard";
                gameBoard.populateGrid(25);
                gameBoard.stopWatch.Start();
            }
            //gameBoard.populateGrid();
            gameBoard.StartPosition = FormStartPosition.CenterScreen;
            gameBoard.Show();
            this.Hide();

        }
    }
}
