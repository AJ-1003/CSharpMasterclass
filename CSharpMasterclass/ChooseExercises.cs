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
            var section2 = new Section2();
            var section3 = new Section3();
            var section4 = new Section4();
            var section5 = new Section5();
            var section6 = new Section6();
            var section7 = new Section7();
            var section9 = new Section10();
            var section10 = new Section10();

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
                case "5":
                    section6.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "6":
                    section7.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "7":
                    section9.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "8":
                    section10.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                default:
                    break;
            }
        }
    }
}
