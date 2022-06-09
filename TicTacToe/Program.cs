using CSharpMasterclass;

char[,] playFieldInitial =
{
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

char[,] playField =
{
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

int turns = 0;

void SetField()
{
    Console.Clear();
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2} ", playField[0, 0], playField[0, 1], playField[0, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
    Console.WriteLine("     |     |     ");
    turns++;
}

void SetXOrO(int player, int input)
{
    char playerSign;

    if (player == 1)
    {
        playerSign = 'X';
    }
    else
    {
        playerSign = 'O';
    }

    switch (input)
    {
        case 1:
            playField[0, 0] = playerSign;
            break;            
        case 2:               
            playField[0, 1] = playerSign;
            break;            
        case 3:               
            playField[0, 2] = playerSign;
            break;            
        case 4:               
            playField[1, 0] = playerSign;
            break;            
        case 5:               
            playField[1, 1] = playerSign;
            break;            
        case 6:               
            playField[1, 2] = playerSign;
            break;            
        case 7:               
            playField[2, 0] = playerSign;
            break;            
        case 8:               
            playField[2, 1] = playerSign;
            break;            
        case 9:               
            playField[2, 2] = playerSign;
            break;
    }
}

void CheckWinner()
{
    for (var row = 0; row < 3; row++)
    {
        if (playField[row, 0] == playField[row, 1] && playField[row, 1] == playField[row, 2])
        {
            CheckPlayerThatWon(playField[row, 0]);
        }
    }

    // vertical check
    for (var col = 0; col < 3; col++)
    {
        if (playField[0, col] == playField[1, col] && playField[1, col] == playField[2, col])
        {
            CheckPlayerThatWon(playField[0, col]);
        }
    }

    // diagonal check
    if (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2])
    {
        CheckPlayerThatWon(playField[0, 0]);
    }

    // diagonal check
    if (playField[2, 0] == playField[1, 1] && playField[1, 1] == playField[0, 2])
    {
        CheckPlayerThatWon(playField[2, 0]);
    }

    if (turns == 10)
    {
        Console.WriteLine("DRAW - There was no winner");
        Console.WriteLine("Press any key to reset the game!");
        Console.ReadKey();
        ResetField();
    }
}

void CheckPlayerThatWon(char player)
{
    if (player == 'X')
    {
        Console.WriteLine();
        Console.WriteLine("Player 1 has won!!");
    }
    else if (player == 'O')
    {
        Console.WriteLine();
        Console.WriteLine("Player 2 has won!!");
    }

    Console.WriteLine("Press any key to reset the game!");
    Console.ReadKey();
    ResetField();
}

void ResetField()
{
    playField = playFieldInitial;
    turns = 0;
    SetField();
}

int player = 2;
int input = 0;
bool correctInput;

do
{
    if (player == 2)
    {
        player = 1;
        SetXOrO(player, input);
    }
    else if (player == 1)
    {
        player = 2;
        SetXOrO(player, input);
    }

    SetField();
    CheckWinner();

    do
    {
        Console.Write($"Player{player}: Choose your field! ");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please enter a number!");
        }

        if (input == 1 && playField[0, 0] == '1')
        {
            correctInput = true;
        }
        else if (input == 2 && playField[0, 1] == '2')
        {
            correctInput = true;
        }
        else if (input == 3 && playField[0, 2] == '3')
        {
            correctInput = true;
        }
        else if (input == 1 && playField[0, 0] == '1')
        {
            correctInput = true;
        }
        else if (input == 4 && playField[1, 0] == '4')
        {
            correctInput = true;
        }
        else if (input == 5 && playField[1, 1] == '5')
        {
            correctInput = true;
        }
        else if (input == 6 && playField[1, 2] == '6')
        {
            correctInput = true;
        }
        else if (input == 7 && playField[2, 0] == '7')
        {
            correctInput = true;
        }
        else if (input == 8 && playField[2, 1] == '8')
        {
            correctInput = true;
        }
        else if (input == 9 && playField[2, 2] == '9')
        {
            correctInput = true;
        }
        else
        {
            Console.WriteLine("Incorrect input! Please use another field!");
            correctInput = false;
        }

    } while (!correctInput);
} while (true);