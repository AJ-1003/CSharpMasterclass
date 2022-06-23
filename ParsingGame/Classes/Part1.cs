using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingGame.Classes
{
    public class Part1
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public Part1(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void ReadAllLinesAndSplit()
        {
            string[] lines = File.ReadAllLines(InputFilePath);
            foreach (var line in lines)
            {
                if (line.Contains("split"))
                {
                    string[] splitReturn = line.Split(' ');
                    using (StreamWriter sw = new StreamWriter(OutputFilePath, true))
                    {
                        sw.Write($"{splitReturn[4]} ");
                    }
                }
            }
        }
    }
}
