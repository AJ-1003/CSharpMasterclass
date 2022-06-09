using CSharpMasterclass.Exercise_Classes.Section_7;
using MasterclassLibrary.Section_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section7
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
            var validateInput = new ValidateInputAndDataType();
            string userInput;
            string optionInput;
            int option = 0;
            var lineBreak = "===================================================================";

            do
            {
                Console.WriteLine("Enter any value");
                Console.Write("-> ");
                userInput = Console.ReadLine().Trim();

                Console.WriteLine("Select the data type to validate the input you have entered against:");
                Console.WriteLine("Press 1 for String\n" +
                    "Press 2 for Integer\n" +
                    "Press 3 for Boolean\n" +
                    "Press Q to Exit");
                Console.Write("-> ");
                optionInput = Console.ReadLine().Trim();
                if (optionInput.ToLower() != "q")
                {
                    option = Convert.ToInt32(optionInput);
                }
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        if (validateInput.CheckInputIsString(userInput))
                        {
                            Console.WriteLine(lineBreak);
                            Console.WriteLine($"You have entered the value: {userInput}");
                            Console.WriteLine("It is a valid: String");
                            Console.WriteLine(lineBreak);
                        }
                        else
                        {
                            Console.WriteLine(lineBreak);
                            Console.WriteLine($"You have entered the value: {userInput}");
                            Console.WriteLine("It is an invalid: String");
                            Console.WriteLine(lineBreak);
                        }
                        break;
                    case 2:
                        if (validateInput.CheckInputIsInteger(userInput))
                        {
                            Console.WriteLine(lineBreak);
                            Console.WriteLine($"You have entered the value: {userInput}");
                            Console.WriteLine("It is a valid: Integer");
                            Console.WriteLine(lineBreak);
                        }
                        else
                        {
                            Console.WriteLine(lineBreak);
                            Console.WriteLine($"You have entered the value: {userInput}");
                            Console.WriteLine("It is an invalid: Integer");
                            Console.WriteLine(lineBreak);
                        }
                        break;
                    case 3:
                        if (validateInput.CheckInputIsBool(userInput))
                        {
                            Console.WriteLine(lineBreak);
                            Console.WriteLine($"You have entered the value: {userInput}");
                            Console.WriteLine("It is a valid: Boolean");
                            Console.WriteLine(lineBreak);
                        }
                        else
                        {
                            Console.WriteLine(lineBreak);
                            Console.WriteLine($"You have entered the value: {userInput}");
                            Console.WriteLine("It is an invalid: Boolean");
                            Console.WriteLine(lineBreak);
                        }
                        break;
                    default:
                        if (optionInput.ToLower() != "q")
                        {
                            throw new Exception("Please select a valid option.");
                        }
                        break;
                }
            } while (optionInput.ToLower() != "q");
        }

        public void Exercise2()
        {
            var ticTacToe = new TicTacToe();
            var gameOver = false;

            string playerInput;

            ticTacToe.RestartGame();
            do
            {
                if (ticTacToe.GetPlayerInput(ticTacToe.Player1))
                {
                    continue;
                }
                else
                {
                    ticTacToe.GetPlayerInput(ticTacToe.Player2);
                }
            } while (!gameOver);
        }

        public void Exercise3()
        {
            var jaggedArray = new JaggedArrayIntroductions();

            string[][] friendsArray = new string[][]
            {
                new string[] { "F1 - Family Member 1", "F1 - Family Member 2" },
                new string[] { "F2 - Family Member 1", "F2 - Family Member 2" },
                new string[] { "F3 - Family Member 1", "F3 - Family Member 2" }
            };

            jaggedArray.Introductions(friendsArray);
        }

        public void Exercise4()
        {
            var hashTable = new InsertValuesIntoHashTable();
            var students = new Student[5];

            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            hashTable.InsertValues(students);
        }
    }
}
