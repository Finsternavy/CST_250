using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        public bool gameGoing = false;
        public int highScore = 0;
        public string difficulty = "Easy";
        private int easyDifficultyScale = 1;
        private int mediumDifficultyScale = 2;
        private int hardDifficultyScale = 3;
        private int defaultTargetWidth = 0;

        public Form1()
        {
            InitializeComponent();
            targetButton.Enabled = false;
            decoyButton.Enabled = false;
            formButton.Enabled = false;
            playAgainButton.Enabled = false;
            playAgainButton.Visible = false;
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            gameGoing = true;
            targetButton.Enabled = true;
            decoyButton.Enabled = true;
            formButton.Enabled = true;
            defaultTargetWidth = targetButton.Width;
            watch.Start();
        }

        private void stopButton_Click(object sender, System.EventArgs e)
        {
            gameGoing = false;
            targetButton.Enabled = false;
            decoyButton.Enabled = false;
            formButton.Enabled = false;
            watch.Stop();
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            gameGoing = false;
            targetButton.Enabled = false;
            decoyButton.Enabled = false;
            formButton.Enabled = false; 
            hitsValueLabel.Text = "0";
            label1.Text = "0";
            watch.Reset();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if(watch.Elapsed.TotalSeconds > 1)
            {
                string elapsedTime = watch.Elapsed.Seconds.ToString();
                label1.Text = elapsedTime.ToString();
            }


            if(gameGoing == true)
            {
                if (random.Next(0, 10) < 5)
                {
                    targetButton.Left = random.Next(0, this.Width);
                    targetButton.Top = random.Next(0, this.Height);
                    targetButton.Visible = true;

                    decoyButton.Left = random.Next(0, this.Width);
                    decoyButton.Top = random.Next(0, this.Height);
                    decoyButton.Visible = true;
                }

                if(watch.Elapsed.TotalSeconds > 30)
                {
                    watch.Stop();
                    endGame();
                }

                adjustDifficulty();
            }
        }

        private void adjustDifficulty()
        {
            int hits;
            if (int.TryParse(hitsValueLabel.Text, out hits))
            {
                if (hits > 10)
                {
                    difficulty = "Hard";
                    targetButton.Width = defaultTargetWidth / hardDifficultyScale;
                    timer1.Interval = 300;
                }

                if (hits > 5)
                {
                    difficulty = "Medium";
                    targetButton.Width = defaultTargetWidth / mediumDifficultyScale;
                    timer1.Interval = 700;
                }

                if (hits <= 5)
                {
                    difficulty = "Easy";
                    targetButton.Width = defaultTargetWidth / easyDifficultyScale;
                }
            }
        }

        private void endGame()
        {
            int yourScore;
            int highScore;

            if(int.TryParse(hitsValueLabel.Text, out yourScore) && int.TryParse(highScoreValueLabel.Text, out highScore))
            {
                if(yourScore > highScore)
                {
                    highScoreValueLabel.Text = yourScore.ToString();
                }
            }

            targetButton.Enabled = false;
            formButton.Enabled = false;
            gameGoing = false;
            playAgainButton.Enabled = true;
            playAgainButton.Visible = true;

        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            targetButton.Visible = false;

            int hits;

            if(int.TryParse(hitsValueLabel.Text, out hits))
            {
                hits = hits + 1;
                hitsValueLabel.Text = hits.ToString();
            }
        }

        private void decoyButton_Click(object sender, EventArgs e)
        {
            decoyButton.Visible = false;

            int hits;

            if (int.TryParse(hitsValueLabel.Text, out hits))
            {
                hits = hits / 2;
                hitsValueLabel.Text = hits.ToString();
            }
        }

        private void formButton_Click(object sender, EventArgs e)
        {
            int hits;

            if (int.TryParse(hitsValueLabel.Text, out hits))
            {
                hits = hits - 3;
                hitsValueLabel.Text = hits.ToString();
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            watch.Reset();
            hitsValueLabel.Text = "0";
            targetButton.Enabled = false;
            gameGoing = false;

            playAgainButton.Enabled = false;
            playAgainButton.Visible = false;
        }
    }
}
