using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace Minesweeper_GUI
{
    public partial class HighScoreForm : Form
    {
        List<PlayerStats> stats = new List<PlayerStats>();
        BindingSource statsBinding = new BindingSource();
        PlayerStats playerStats;
        string filePath = @"C:\demos\highscores.txt";

        public HighScoreForm(string difficulty, int successfulClicks, int elapsedTime)
        {
            InitializeComponent();
            playerStats = new PlayerStats();
            playerStats.difficultyPlayed = difficulty;
            playerStats.successfulCellsClicked = successfulClicks;
            playerStats.elapsedTime = elapsedTime;
            playerStats.calculateScoreByDifficulty();
            pointsLabel.Text = playerStats.score.ToString();
            timeLabel.Text = playerStats.elapsedTime.ToString();
            loadHighScores();
            setBindings();
            
        }

        private void setBindings()
        {
            statsBinding.DataSource = stats;
            nameListBox.DataSource = statsBinding;
            nameListBox.DisplayMember = "name";
            difficultyListBox.DataSource = statsBinding;
            difficultyListBox.DisplayMember = "difficultyPlayed";
            elapsedTimeListBox.DataSource = statsBinding;
            elapsedTimeListBox.DisplayMember = "elapsedTime";
            scoreListBox.DataSource = statsBinding;
            scoreListBox.DisplayMember = "score";

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            playerStats.name = enterNameTextBox.Text;
            playerStats.calculateScoreByDifficulty();

            stats.Add(playerStats);
            stats.Sort();

            statsBinding.ResetBindings(false);

            saveHighScores();

        }

        private void saveHighScores()
        {
            List<string> outputLines = new List<string>();

            foreach(PlayerStats playerStats in stats)
            {
                outputLines.Add(playerStats.name + "," + playerStats.difficultyPlayed + "," + playerStats.elapsedTime + "," + playerStats.score.ToString());
            }

            string outPath = @"C:\demos\highscores.txt";
            File.WriteAllLines(outPath, outputLines);
        }

        private void loadHighScores()
        {
            stats.Clear();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                int lineNumber = 1;
                List<int> errorLines = new List<int>();

                foreach (string line in lines)
                {
                    char delimiter = ',';
                    int frequency = Regex.Matches(line, delimiter.ToString()).Count;


                    if (frequency == 3)
                    {
                        string[] entries = line.Split(',');

                        PlayerStats playerStats = new PlayerStats();
                        playerStats.name = entries[0];
                        playerStats.difficultyPlayed = entries[1];
                        string time = entries[2];
                        string score = entries[3];
                        int parsedTime;
                        if(int.TryParse(time, out parsedTime))
                        {
                            playerStats.elapsedTime = parsedTime;
                        }
                        int parsedScore;
                        if (int.TryParse(score, out parsedScore))
                        {
                            playerStats.score = parsedScore;
                        }

                        stats.Add(playerStats);
                    }
                    else
                    {
                        errorLines.Add(lineNumber);
                        lineNumber++;
                    }


                }

            }
            catch
            {
                MessageBox.Show("Error loading file");
            }

            statsBinding.ResetBindings(false);
        }
    }
}
