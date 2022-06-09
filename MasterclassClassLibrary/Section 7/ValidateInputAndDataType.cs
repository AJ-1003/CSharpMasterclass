using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_7
{
    public class ValidateInputAndDataType
    {
        public bool CheckInputIsString(string userInput)
        {
            var validation = false;

            foreach (var letter in userInput)
            {
                var checkLetter = Char.ToString(letter);
                int numberOut;

                if (Int32.TryParse(checkLetter, out numberOut))
                {
                    //Console.WriteLine(numberOut);
                    validation = false;
                    break;
                }
                else
                {
                    validation = true;
                }
            }

            return validation;
        }

        public bool CheckInputIsInteger(string userInput)
        {
            var validation = false;

            try
            {
                var numberValue = Convert.ToInt32(userInput);
                if (numberValue >= 0 || numberValue < 0)
                {
                    validation = true;
                }
            }
            catch
            {
                validation = false;
            }

            return validation;
        }

        public bool CheckInputIsBool(string userInput)
        {
            var validation = false;

            try
            {
                if (Convert.ToBoolean(userInput) == true || Convert.ToBoolean(userInput) == false)
                {
                    validation = true;
                }
            }
            catch
            {
                validation = false;
            }

            return validation;
        }
    }
}
