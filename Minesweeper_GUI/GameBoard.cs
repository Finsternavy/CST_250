using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper_GUI
{
    public partial class GameBoard : Form
    {
        Form startMenu;
        static public Board board;
        public Button[,] buttonGrid;
        Bitmap bombBitmap = new Bitmap(@"C:\Users\Finst\Documents\GitHub\CST-250\CST_250\Minesweeper_GUI\Images\bomb.png");
        Bitmap flagBitmap = new Bitmap(@"C:\Users\Finst\Documents\GitHub\CST-250\CST_250\Minesweeper_GUI\Images\flag.png");
        Image bombImage;
        Image flagImage;
        public Stopwatch stopWatch = new Stopwatch();
        public string difficulty;
        int successfulCellsClicked;

        public GameBoard(StartMenu startMenu)
        {
            InitializeComponent();
            bombImage = bombBitmap;
            flagImage = flagBitmap;
            this.startMenu = startMenu;
            startMenu.gameBoard = this;

            this.Hide();
            startMenu.Show();
        }

        public void populateGrid(int size)
        {
            board = new Board(size);
            buttonGrid = new Button[size,size];

            int buttonSize = panel1.Width / board.getSize();
            panel1.Height = panel1.Width;

            for (int row = 0; row < board.getSize(); row++)
            {
                for (int column = 0; column < board.getSize(); column++)
                {
                    buttonGrid[row, column] = new Button();

                    buttonGrid[row, column].Width = buttonSize;
                    buttonGrid[row, column].Height = buttonSize;
                    

                    buttonGrid[row, column].MouseDown += Grid_Button_MouseDown;
                    panel1.Controls.Add(buttonGrid[row, column]);
                    buttonGrid[row, column].Location = new Point(buttonSize * row, buttonSize * column);
                    

                    buttonGrid[row, column].Tag = row.ToString() + "|" + column.ToString();
                }
            }

            panel1.Show();
            stopWatch.Start();
        }

       
        private void Grid_Button_MouseDown(object sender, MouseEventArgs e)
        {
            string[] stringArray = (sender as Button).Tag.ToString().Split('|');
            int row = int.Parse(stringArray[0]);
            int column = int.Parse(stringArray[1]);

            Cell currentCell = board.grid[row, column];


            (sender as Button).BackColor = Color.Cornsilk;

            updateButtonLabels();

            switch (e.Button)
            {
                case MouseButtons.Left:

                    if (board.grid[currentCell.getRow(), currentCell.getColumn()].getLive() == true)
                    {
                        for (int r = 0; r < board.getSize(); r++)
                        {
                            for (int c = 0; c < board.getSize(); c++)
                            {
                                board.grid[r, c].setVisited(true);
                            }
                        }
                        gameLoss();
                        stopWatch.Stop();
                        MessageBox.Show("You lose! Better luck next time!");
                        return;

                    }
                    else if (board.grid[currentCell.getRow(), currentCell.getColumn()].getLiveNeighbors() == 0)
                    {
                        board.floodFill(currentCell.getRow(), currentCell.getColumn());
                        updateButtonLabels();
                        this.successfulCellsClicked = this.successfulCellsClicked + board.floodFillCellsEffected;
                        board.floodFillCellsEffected = 0;
                    }
                    else
                    {
                        this.successfulCellsClicked++;
                        board.grid[currentCell.getRow(), currentCell.getColumn()].setVisited(true);
                        buttonGrid[currentCell.getRow(), currentCell.getColumn()].Text = board.grid[currentCell.getRow(), currentCell.getColumn()].getLiveNeighbors().ToString();
                        buttonGrid[currentCell.getRow(), currentCell.getColumn()].Enabled = false;
                    }

                    if (checkForWin())
                    {
                        gameWin();
                        stopWatch.Stop();
                        int elapsedTime = stopWatch.Elapsed.Seconds;
                        MessageBox.Show("You won!!!  Your total time was: " + stopWatch.Elapsed.Seconds.ToString());

                        HighScoreForm highScoreForm = new HighScoreForm(difficulty, successfulCellsClicked, elapsedTime);
                        highScoreForm.Show();
                    }

                    break;

                case MouseButtons.Right:

                    buttonGrid[currentCell.getRow(), currentCell.getColumn()].Image =
                        (Image)(new Bitmap(flagImage, new Size(buttonGrid[currentCell.getRow(), currentCell.getColumn()].Width, buttonGrid[currentCell.getRow(), currentCell.getColumn()].Height)));

                    break;
            }
            
        }

        private void gameLoss()
        {
            for (int r = 0; r < board.getSize(); r++)
            {
                for (int c = 0; c < board.getSize(); c++)
                {
                    buttonGrid[r, c].Enabled = false;
                    if(board.grid[r, c].getLive() == true)
                    {
                        buttonGrid[r, c].Image = (Image)(new Bitmap(bombImage, new Size(buttonGrid[r, c].Width, buttonGrid[r, c].Height)));
                    }
                    else if(board.grid[r, c].getLiveNeighbors() > 0)
                    {
                        buttonGrid[r, c].Text = board.grid[r, c].getLiveNeighbors().ToString();
                    }
                    else
                    {
                        buttonGrid[r, c].Text = "";
                        buttonGrid[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }

        private void gameWin()
        {
            for (int r = 0; r < board.getSize(); r++)
            {
                for (int c = 0; c < board.getSize(); c++)
                {
                    buttonGrid[r, c].Enabled = false;
                    
                    if (board.grid[r, c].getLive() == true && checkForWin() == true)
                    {
                        buttonGrid[r, c].Image = (Image)(new Bitmap(flagImage, new Size(buttonGrid[r, c].Width, buttonGrid[r, c].Height)));
                    }
                    else if (board.grid[r, c].getLiveNeighbors() > 0)
                    {
                        buttonGrid[r, c].Text = board.grid[r, c].getLiveNeighbors().ToString();
                    }
                    else
                    {
                        buttonGrid[r, c].Text = "";
                        buttonGrid[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }


        public void updateButtonLabels()
        {
            for (int row = 0; row < board.getSize(); row++)
            {
                for (int column = 0; column < board.getSize(); column++)
                {
                    if (board.grid[row, column].getVisited() == true && buttonGrid[row, column].Enabled == true)
                    {
                        buttonGrid[row, column].Text = board.grid[row, column].getLiveNeighbors().ToString();
                        
                        buttonGrid[row, column].Enabled = false;
                    }
                    if(board.grid[row, column].getLiveNeighbors() == 0 && board.grid[row, column].getVisited() == true)
                    {
                        buttonGrid[row, column].Text = "";
                        buttonGrid[row, column].BackColor = Color.Gray;
                    }
                }
            }
        }

        private bool checkForWin()
        {
            int count = 0;

            for (int row = 0; row < board.getSize(); row++)
            {
                for (int column = 0; column < board.getSize(); column++)
                {
                    if(board.grid[row, column].getLive() == false && board.grid[row, column].getVisited() == false)
                    {
                        count++;
                    }
                }
            }

            if (count > 0) return false;
            else
                return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startMenu.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string elapsedTIme = stopWatch.Elapsed.Seconds.ToString();
            elapsedTimeLabel.Text = elapsedTIme.ToString();
            
        }
    }
}
