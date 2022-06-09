using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee()
        {

        }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours) : base(name, firstName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public override void Work()
        {
            Console.WriteLine($"I am only working {WorkingHours} hours");
        }

        public void Learn()
        {
            Console.WriteLine("Learning C#");
        }
    }
}
