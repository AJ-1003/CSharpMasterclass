using CSharpMasterclass.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass
{
    public class ChooseExercises
    {
        public void ChooseExercise(string area, int numberOfExercises)
        {
            var section2 = new Section2Exercises();
            var section3 = new Section3Exercises();
            var section4 = new Section4Exercises();
            var section5 = new Section5Exercises();

            Console.WriteLine("Choose the exercise that needs to be tested:");
            for (int i = 1; i <= numberOfExercises; i++)
            {
                Console.WriteLine($"Exercise {i}");
            }
            Console.Write("-> ");
            var exercise = Console.ReadLine().Trim();
            Console.WriteLine();
            var exerciseNumber = int.Parse(exercise);

            switch (area)
            {
                case "1":
                    section2.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "2":
                    section3.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "3":
                    section4.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "4":
                    section5.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                default:
                    break;
            }
        }
    }
}
