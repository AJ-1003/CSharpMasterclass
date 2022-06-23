using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParsingGame.Classes
{
    public class Part2
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public Part2(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        public void ConvertNumbersToChars()
        {
            string[] lines = File.ReadAllLines(InputFilePath);
            var pattern = @"\d{3}|\d{2}";
            var output = "";
            Regex regex = new Regex(pattern);

            foreach (var line in lines)
            {
                MatchCollection matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    int value;
                    char ch;
                    GroupCollection group = match.Groups;
                    value = int.Parse(group[0].Value);
                    ch = (char)value;

                    output += ch;
                }
            }

            using (StreamWriter sw = new StreamWriter(OutputFilePath, true))
            {
                sw.Write($"{output}");
            }
        }
    }
}
