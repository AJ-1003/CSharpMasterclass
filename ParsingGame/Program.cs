using ParsingGame.Classes;

namespace ParsingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileInput1 = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\ParsingGame\Game Files\input1.txt";
            var fileOutput = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\ParsingGame\Game Files\output1.txt";

            var fileInput2 = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\ParsingGame\Game Files\input2.txt";

            var part1 = new Part1(fileInput1, fileOutput);
            var part2 = new Part2(fileInput2, fileOutput);

            part1.ReadAllLinesAndSplit();
            part2.ConvertNumbersToChars();
        }
    }
}