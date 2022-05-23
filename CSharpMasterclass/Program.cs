using CSharpMasterclass;
using static System.Net.Mime.MediaTypeNames;

var exerciseChoice = new ChooseExercises();
string input;
int numberOfTests = 1;

do
{
    if (numberOfTests > 1)
    {
        Console.WriteLine();
    }
    Console.WriteLine($"Choose the area that needs to be tested or press 'Q' to exit: ({numberOfTests})");
    Console.WriteLine(
        "1: Section 2\n" +
        "2: Section 3\n" +
        "3: Section 4" +
        "4: Section 5");

    Console.Write("-> ");
    input = Console.ReadLine();

    if (input == "1" || input == "2" || input == "3" || input == "4")
    {
        switch (input)
        {
            case "1":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 3);
                break;
            case "2":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 1);
                break;
            case "3":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 3);
                break;
            case "4":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 1);
                break;
            default:
                break;
        }
        numberOfTests++;
    }
    else if (input != "q")
    {
        Console.WriteLine();
        Console.WriteLine("!!! NOTE: Please enter a valid option or press 'Q' to exit. !!!");
        Console.WriteLine();
    }
} while (input.ToLower() != "q" && numberOfTests <= 10);