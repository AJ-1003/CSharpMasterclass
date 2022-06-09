using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class TV : ElectronicDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("You are watching TV!");
            }
            else
            {
                Console.WriteLine("The TV is not switched on!");
            }
        }
    }
}
