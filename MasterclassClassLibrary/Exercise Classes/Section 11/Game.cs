using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_11
{
    public struct Game
    {
        public string Name;
        public string Developer;
        public string Rating;

        public Game(string name, string developer, string rating)
        {
            Name = name;
            Developer = developer;
            Rating = rating;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} was developed by {Developer}, and has a rating of {Rating}");
        }
    }
}
