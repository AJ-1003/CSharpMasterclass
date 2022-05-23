using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_4
{
    public class CheckHighScore
    {
        private int HighScore { get; set; } = 100;
        private string HighScoreHolder { get; set; } = "John Doe";

        public string CheckForNewHighScore(int score, string playeName)
        {
            string outcome;

            if (score > HighScore)
            {
                outcome = $"New highscore is '{score}'\n" +
                    $"New highscore holder is '{playeName}'";
            }
            else
            {
                outcome = $"The old highscore of '{HighScore}' could not be broken and is still held by '{HighScoreHolder}'";
            }

            return outcome;
        }
    }
}
