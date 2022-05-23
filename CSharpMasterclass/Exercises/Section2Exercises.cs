using MasterclassLibrary.Section2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section2Exercises
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
            var stringOutput = new DifferentStringOutputs();
            string userInput;

            Console.WriteLine("Please enter your name and press 'Enter'.");
            Console.Write("-> ");
            userInput = Console.ReadLine();

            var result = stringOutput.PrintDifferentStringOuputs(userInput);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void Exercise2()
        {
            var findChar = new FindCharInString();
            string userString;
            char searchForChar;

            Console.WriteLine("Please enter a string");
            Console.Write("-> ");
            userString = Console.ReadLine().ToLower();

            Console.WriteLine("Enter a character that you would like to search for in the string");
            Console.Write("-> ");
            searchForChar = Console.ReadLine().ToLower()[0];
            Console.WriteLine(findChar.FindCharIndex(userString, searchForChar));
            Console.WriteLine();

            var concatName = new PrintInputOnSingleLine();
            string firstName;
            string lastName;

            Console.WriteLine("Enter the following information");
            Console.Write("Firstname: ");
            firstName = Console.ReadLine();
            Console.Write("Lastname: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {concatName.PrintUserInputOnOneLine(firstName, lastName)}");
        }

        public void Exercise3()
        {
            var convertString = new ConvertString();
            string userString;

            Console.WriteLine("Enter a value to convert to a whole number.");
            Console.Write("-> ");
            userString = Console.ReadLine();
            Console.WriteLine(convertString.ConvertStringNumberToInt(userString));
        }
    }
}
