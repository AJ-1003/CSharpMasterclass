namespace MasterclassLibrary
{
    public class StringChallenge1
    {
        public List<string> PrintDifferentStringOuputs(string input)
        {
            var output = new List<string>();

            output.Add(input.ToUpper());
            output.Add(input.ToLower());
            output.Add(input.Substring(input.IndexOf(' ')).Trim());

            return output;
        }
    }
}