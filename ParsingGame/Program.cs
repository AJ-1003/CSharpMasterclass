namespace ParsingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\ParsingGame\Game Files\input.txt";
            var fileOutput = @"C:\Users\iajor\source\isometrix training repos\CSharpMasterclass\ParsingGame\Game Files\output.txt";

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (line.Contains("split"))
                {
                    string[] splitReturn = line.Split(' ');
                    using (StreamWriter sw = new StreamWriter(fileOutput, true))
                    {
                        sw.Write($"{splitReturn[4]} ");
                    }
                }
            }
        }
    }
}