using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section2
{
    public class FindCharInString
    {
        public string FindCharIndex(string searchString, char forChar)
        {
            var indexOfChar = searchString.IndexOf(forChar);
            string result;

            if (indexOfChar == -1)
            {
                result = "The character does not exist in string";
            }
            else
            {
                result = $"The first index of '{forChar}' is '{indexOfChar}'";
            }

            return result;
        }
    }
}
