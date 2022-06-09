using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_10
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIdInfo carIdInfo = new CarIdInfo();

        public void SetCarIdInfo(int id, string owner)
        {
            carIdInfo.Id = id;
            carIdInfo.Owner = owner;
        }

        public void GetCarIdInfo()
        {
            Console.WriteLine($"The car's ID is {carIdInfo.Id} and is owned by {carIdInfo.Owner}.");
        }

        public Car()
        {

        }

        public Car(int hP, string color)
        {
            HP = hP;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"The car has {HP} horsepower and is {Color}!");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
