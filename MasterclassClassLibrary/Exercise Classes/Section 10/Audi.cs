using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_10
{
    // Audi is a Car
    public class Audi : Car
    {
        private string brand;
        public string Model { get; set; }

        public Audi(string model, int hP, string color) : base(hP, color)
        {
            brand = "Audi";
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The {brand} {Model} has {HP} horsepower and is {Color}!");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {brand} {Model} was repaired!");
        }
    }
}
