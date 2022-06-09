using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Boss : Employee
    {
        public bool CompanyCar { get; set; }

        public Boss()
        {

        }

        public Boss(string name, string firstName, int salary, bool companyCar) : base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Being the boss!");
        }
    }
}
