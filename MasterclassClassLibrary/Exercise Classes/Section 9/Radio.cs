using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Radio : ElectronicDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void ListenToTheRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("You are listening to the radio!");
            }
            else
            {
                Console.WriteLine("The radio is not switched on!");
            }
        }
    }
}
