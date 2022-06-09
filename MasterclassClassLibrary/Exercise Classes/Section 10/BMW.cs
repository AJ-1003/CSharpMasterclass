using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_10
{
    // BMW is a Car
    public class BMW : Car
    {
        private string brand;
        public string Model { get; set; }

        public BMW()
        {

        }

        public BMW(string model, int hP, string color) : base(hP, color)
        {
            brand = "BMW";
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The {brand} {Model} has {HP} horsepower and is {Color}!");
        }

        // only override methods can be sealed
        public sealed override void Repair()
        {
            Console.WriteLine($"The {brand} {Model} was repaired!");
        }
    }
}
