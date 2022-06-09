using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_9
{
    public class Animal
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        // virtual allows sub-classes to override this method
        public virtual void MakeSound()
        {

        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating!");
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing!");
        }
    }
}
