using MasterclassLibrary;

/* ========================< Assignment 1 >======================== */
string stringForFloat = "0,85"; // datatype should be float
string stringForInt = "12345"; // datatype should be int

var floatOutput = float.Parse(stringForFloat);
var intOutput = int.Parse(stringForInt);

Console.WriteLine($"The float value is {floatOutput}");
Console.WriteLine($"The int value is {intOutput}");
Console.WriteLine();

/* ------------------------< Challenge 1 >------------------------ */
var stringOutput = new StringChallenge1();
string userInput;

Console.WriteLine("Please enter your name and press 'Enter'.");
Console.Write("-> ");
userInput = Console.ReadLine();

var result = stringOutput.PrintDifferentStringOuputs(userInput);
foreach (var item in result)
{
    Console.WriteLine(item);
}