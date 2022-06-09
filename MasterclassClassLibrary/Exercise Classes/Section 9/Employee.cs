using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        private int Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Working!");
        }

        public void Pause()
        {
            Console.WriteLine("On lunch break.");
        }
    }
}
