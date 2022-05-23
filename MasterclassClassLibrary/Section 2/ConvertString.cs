using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section2
{
    public class ConvertString
    {
        public string ConvertStringNumberToInt(string userInput)
        {
            string output;
            try
            {
                var result = Convert.ToInt32(userInput);
                output = $"The result is {result}";
            }
            catch
            {
                output = $"'{userInput}' cannot be converted to a whole number.";
            }
            return output;
        }
    }
}
