using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_5
{
    public class AverageScoreOfStudents
    {
        public float CalculateAverageScores(List<float> scores)
        {
            float sumOfScores = 0.0f;
            var numberOfScores = scores.Count;
            
            foreach (var score in scores)
            {
                sumOfScores += score;
            }

            return sumOfScores / numberOfScores;
        }
    }
}
