using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterclass.Assignments
{
    public class Assignment1
    {
        public void ExerciseParsing()
        {
            string stringForFloat = "0,85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            var floatOutput = float.Parse(stringForFloat);
            var intOutput = int.Parse(stringForInt);

            Console.WriteLine($"The float value is {floatOutput}");
            Console.WriteLine($"The int value is {intOutput}");
            Console.WriteLine();
        }
    }
}
