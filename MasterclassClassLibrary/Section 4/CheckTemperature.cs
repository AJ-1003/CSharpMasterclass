using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_4
{
    public class CheckTemperature
    {
        public string CheckTemperatureValue(int temperature)
        {
            string temperatureMessage;

            temperatureMessage = temperature <= 15 ? "It is too cold here" : (temperature >= 16 && temperature <= 28) ? "It is ok" : "It is hot here";

            return temperatureMessage;
        }
    }
}
