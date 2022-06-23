using MasterclassLibrary.Exercise_Classes.Section_12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Exercises
{
    public class Section12
    {
        public void ExecuteExercise(string exerciseName)
        {
            if (GetType().GetMethod(exerciseName) != null)
            {
                MethodInfo method = GetType().GetMethod(exerciseName);
                method.Invoke(this, null);
            }
        }

        // ======================================< EXERCISE 1 >====================================== //
        public delegate bool FilterDelegate(Person p);

        public void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"{person.Name}, is {person.Age} years old");
                }
            }
        }

        // ---------< FILTERS >--------- //
        public bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        public bool IsAdult(Person p)
        {
            return p.Age > 18;
        }
        // ======================================< EXERCISE 1 >====================================== //

        public void Exercise1()
        {
            var people = new List<Person>()
            {
                new Person() { Name = "Ian", Age = 27 },
                new Person() { Name = "Chante", Age = 27 },
                new Person() { Name = "Alicia", Age = 22 },
                new Person() { Name = "Dewald", Age = 13 }
            };

            DisplayPeople("Kids", people, IsMinor);

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age > 18 && p.Age < 30;
            };

            Console.WriteLine();
            DisplayPeople("Adults", people, filter);

            Console.WriteLine();
            // statement lambda
            var searchKeyword = "I";
            DisplayPeople($"Age > 20 with search keyword '{searchKeyword}'", people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Console.WriteLine();
            // expression lambda
            DisplayPeople("Exactly 22: ", people, p => p.Age == 22);
        }
    }
}
