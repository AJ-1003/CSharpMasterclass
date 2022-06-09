using MasterclassLibrary.Section_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section5
    {
        public void ExecuteExercise(string exerciseName)
        {
            if (GetType().GetMethod(exerciseName) != null)
            {
                MethodInfo method = GetType().GetMethod(exerciseName);
                method.Invoke(this, null);
            }
        }

        public void Exercise1()
        {
            var calcScores = new AverageScoreOfStudents();
            var scores = new List<float>();
            string userInput;
            var inputValue = 0.0f;

            Console.WriteLine("Please enter a score between 0 and 20 or '-1' to finish.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();

                try
                {
                    inputValue = float.Parse(userInput);
                    if (inputValue >= 0 && inputValue <= 20)
                    {
                        scores.Add(inputValue);
                    }
                    else if (inputValue != -1)
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Value entered is not within the range of 0 to 20. Please try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("Incorrect value entered. Please try again.");
                }
            } while (inputValue != -1);
            Console.WriteLine("===================================================================");
            Console.WriteLine($"The average score is: {calcScores.CalculateAverageScores(scores).ToString("F")}");
            Console.WriteLine("===================================================================");
        }
    }
}
