using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_6
{
    public class Human
    {
        // members variables
        private string FirstName;
        private string LastName;
        private string EyeColor;
        private byte Age;

        public Human()
        {
            Console.WriteLine("This is new human class with nothing set against it.");
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            FirstName = firstName;
            LastName = lastName;
            EyeColor = eyeColor;
        }
        
        public Human(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Human(string firstName, string lastName, string eyeColor, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            EyeColor = eyeColor;
            Age = age;
        }

        public void Introduction()
        {
            if (FirstName == null && LastName == null && EyeColor == null && Age <= 0)
            {
                Console.WriteLine("I don't have a name, age, or eye color yet. I was just created.");
            }
            else if (FirstName != null && LastName != null && EyeColor == null && Age <= 0)
            {
                Console.WriteLine($"Hi, my name is {FirstName} {LastName}");
            }
            else if (FirstName != null && LastName != null && EyeColor != null && Age <= 0)
            {
                Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and I have {EyeColor} eyes.");
            }
            else if (FirstName != null && LastName != null && EyeColor == null && Age >= 0)
            {
                if (Age > 1)
                {
                    Console.WriteLine($"Hi, my name is {FirstName} {LastName}. I am {Age} years old.");
                }
                else
                {
                    Console.WriteLine($"Hi, my name is {FirstName} {LastName}. I am {Age} year old.");
                }
            }
            else if (FirstName != null && LastName != null && EyeColor != null && Age >= 0)
            {
                if (Age > 1)
                {
                    Console.WriteLine($"Hi, my name is {FirstName} {LastName}. I have {EyeColor} eyes and I am {Age} years old.");
                }
                else
                {
                    Console.WriteLine($"Hi, my name is {FirstName} {LastName}. I have {EyeColor} eyes and I am {Age} year old.");
                }
            }
        }
    }
}
