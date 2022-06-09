using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_6
{
    public class Box
    {
        // member variables
        private int length;
        private int width;
        //public int height;
        public int volume;
               
        public int Height { get; set; }

        public int FrontSurface
        {
            get
            {
                return length * Height;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    width = -value;
                }
                else
                {
                    width = value;
                }
            }
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be greater than 0");
            }

            this.length = length;
        }

        public int GetLength()
        {
            return length;
        }

        public void DisplayInfo()
        {
            var volume = length * width * Height;

            Console.WriteLine($"The box is {length} units long, {width} units wide, {Height} units high, and has a volume of {volume} units\x00B3");
        }
    }
}
