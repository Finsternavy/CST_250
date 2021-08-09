using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Minesweeper_GUI
{
    class PlayerStats : IComparable<PlayerStats>
    {
        public string name { get; set; }
        public string difficultyPlayed { get; set; }
        public int elapsedTime { get; set; }

        public int successfulCellsClicked { get; set; }

        public int score { get; set; }

        public void calculateScoreByDifficulty()
        {
            switch (difficultyPlayed)
            {
                case "Easy":

                    score = calculateBaseScore();
                    break;

                case "Medium":

                    score = calculateBaseScore() * 2;
                    break;

                case "Hard":

                    score = calculateBaseScore() * 5;
                    break;

                default:
                    break;
            }
        }

        private int calculateBaseScore()
        {
            if ((successfulCellsClicked * 5) - (this.elapsedTime / 60) >= 0)
                return (successfulCellsClicked * 5) - (this.elapsedTime / 60);
            else
                return 0;
        }
        public int CompareTo([AllowNull] PlayerStats other)
        {
            if(this.score == other.score)
            {
                return this.difficultyPlayed.CompareTo(other.difficultyPlayed);
            }
            return other.score.CompareTo(this.score);
        }

    }
}
