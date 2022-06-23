using MasterclassLibrary.Exercise_Classes.Section_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section11
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
            Game game1;

            game1.Name = "Need for Speed";
            game1.Developer = "Ian";
            game1.Rating = "4.2";

            game1.Display();

            Game game2 = new Game("Need for Speed 2", "Ian", "4.1");
            game2.Display();
        }

        public void Exercise2()
        {
            var monday = Day.Monday;
            var tuesday = Day.Tuesday;
            var wednesday = Day.Wednesday;
            var thursday = Day.Thursday;
            var friday = Day.Friday;
            var saturday = Day.Saturday;
            var sunday = Day.Sunday;

            var one = Day.Monday;

            Console.WriteLine(monday == one);
            Console.WriteLine((int)Day.Monday);
            Console.WriteLine((int)Day.Tuesday);
            Console.WriteLine((int)Day.Wednesday);
            Console.WriteLine((int)Day.Thursday);
            Console.WriteLine((int)Day.Friday);
            Console.WriteLine((int)Day.Saturday);
            Console.WriteLine((int)Day.Sunday);
        }

        public void Exercise3()
        {
            var dice = new Random();
            int answer;

            for (var i = 0; i < 6; i++)
            {
                answer = dice.Next(1, 4);
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Yes");
                        break;
                    case 2:
                        Console.WriteLine("Maybe");
                        break;
                    default:
                        Console.WriteLine("No");
                        break;
                }
            }
        }

        public void Exercise4()
        {
            var pattern = @"\d{3}.\d{3}.\d{4}";
            Regex regex = new Regex(pattern);

            var text = "Hi, my number is 060 525 8368";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine($"{matches.Count} hits found: {text}");

            foreach (Match hit in matches)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
        }

        public void Exercise5()
        {
            var customDateTime = new DateTimeCustom();

            var dateTime = new DateTime(1994, 10, 3);

            Console.WriteLine($"My was born {dateTime}");
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            var tomorrow = customDateTime.GetTomorrow();
            var dayOfTomorrow1 = tomorrow.DayOfWeek;
            var dayOfTomorrow2 = tomorrow.Day;
            var firstDayOfYear = customDateTime.GetFirstDayOfYear(1995).DayOfWeek;
            var daysInMonth = DateTime.DaysInMonth(2022, 2);
            var now = DateTime.Now;

            Console.WriteLine($"{tomorrow}");
            Console.WriteLine($"{dayOfTomorrow1}");
            Console.WriteLine($"{dayOfTomorrow2}");
            Console.WriteLine($"{firstDayOfYear}");
            Console.WriteLine($"There are {daysInMonth} days in Feb 2022");
            Console.WriteLine($"hours {now.Hour} / minutes {now.Minute} / seconds {now.Second}");
            Console.WriteLine();

            Console.WriteLine("Enter a date in this format 'yyyy-MM-dd'");
            var dateInput = Console.ReadLine();

            if (DateTime.TryParse(dateInput, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"Days passed since {dateInput}, is {daysPassed.Days}");
            }
        }

        public void Exercise6()
        {
            int? num1 = null;
            int? num2 = 1994;
            int num5;

            double? num3 = new double?();
            double? num4 = 3.412;

            bool? boolVal = new bool?();

            Console.WriteLine($"The nullable numbers are: {num1}, {num2}, {num3}, {num4}");
            Console.WriteLine($"The nullable boolean value is {boolVal}");

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male!");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female!");
            }
            else
            {
                Console.WriteLine("No gender specified!");
            }

            double? num6 = 13.5;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine($"The value of num8 is {num8}");

            // null coalescing operator (??)
            num8 = num6 ?? 8.35;
            Console.WriteLine($"The value of num8 is {num8}");

            num8 = num7 ?? 10.35;
            Console.WriteLine($"The value of num8 is {num8}");
        }
    }
}
