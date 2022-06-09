using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, byte age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            // calls the original method from the base class
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woef!!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
