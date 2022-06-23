using CSharpMasterclass;

var exerciseChoice = new ChooseExercises();
var options = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
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
        "3: Section 4\n" +
        "4: Section 5\n" +
        "5: Section 6\n" +
        "6: Section 7\n" +
        "7: Section 9\n" +
        "8: Section 10\n" +
        "9: Section 11\n" +
        "10: Section 12");

    Console.Write("-> ");
    input = Console.ReadLine();

    if (options.Contains(input))
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
            case "5":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 2);
                break;
            case "6":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 4);
                break;
            case "7":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 4);
                break;
            case "8":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 4);
                break;
            case "9":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 6);
                break;
            case "10":
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