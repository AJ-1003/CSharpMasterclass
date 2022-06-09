using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_7
{
    public class JaggedArrayIntroductions
    {
        public void Introductions(string[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine($"Hello, I am {array[i][j]}");
                }
            }    
        }
    }
}
