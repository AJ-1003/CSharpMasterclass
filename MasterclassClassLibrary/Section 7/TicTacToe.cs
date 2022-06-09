using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Section_7
{
    public class TicTacToe
    {
        private string[] PositionValues { get; set; }
        private string[,] Board { get; set; }

        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public void CreateBoard()
        {
            Board = new string[9, 17];
            var position = 0;

            for (var row = 0; row < 9; row++)
            {
                for (var col = 0; col < 17; col++)
                {
                    if (row == 1 || row == 4 || row == 7)
                    {
                        if (col == 2 || col == 8 || col == 14)
                        {
                            Board[row, col] = PositionValues[position];
                            //Console.Write(Board[row, col]);
                            position++;
                        }
                        else if (col == 5 || col == 11)
                        {
                            Board[row, col] = "|";
                            //Console.Write("|");
                        }
                        else
                        {
                            Board[row, col] = " ";
                            //Console.Write(" ");
                        }
                    }
                    else if (row == 2 || row == 5)
                    {
                        if (col == 5 || col == 11)
                        {
                            Board[row, col] = "|";
                            //Console.Write("|");
                        }
                        else
                        {
                            Board[row, col] = "_";
                            //Console.Write("_");
                        }
                    }
                    else if (col == 5 || col == 11)
                    {
                        Board[row, col] = "|";
                        //Console.Write("|");
                    }
                    else
                    {
                        Board[row, col] = " ";
                        //Console.Write(" ");
                    }
                }
            }
            PrintBoard(Board);
        }

        public void PrintBoard(string[,] board)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("      TicTacToe      ");
            Console.WriteLine("=====================");
            Console.WriteLine();

            for (var row = 0; row < 9; row++)
            {
                for (var col = 0; col < 17; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("-----< PLAYERS >-----");
            Console.WriteLine($"(X): {Player1}");
            Console.WriteLine($"(O): {Player2}");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            CheckBoard(board);
        }

        public void UpdateBoard(string[] newValues)
        {
            PositionValues = newValues;
            Console.Clear();
            CreateBoard();
        }

        public bool CheckBoard(string[,] board)
        {
            /* -----< Positions >----- */
            /*
            board[1, 2] = "1";
            board[1, 8] = "2";
            board[1, 14] = "3";
            board[4, 2] = "4";
            board[4, 8] = "5";
            board[4, 14] = "6";
            board[7, 2] = "7";
            board[7, 8] = "8";
            board[7, 14] = "9";
            */

            // horizontal check
            for (var row = 0; row < 9; row++)
            {
                if (board[row, 2] == board[row, 8] && board[row, 8] == board[row, 14])
                {
                    return true;
                }
            }

            // vertical check
            for (var col = 0; col < 17; col++)
            {
                if (board[1, col] == board[4, col] && board[4, col] == board[7, col])
                {
                    return true;
                }
            }

            // diagonal check
            if (board[1, 2] == board[4, 8] && board[4, 8] == board[7, 14])
            {
                return true;
            }

            // diagonal check
            if (board[1, 14] == board[4, 8] && board[4, 8] == board[7, 2])
            {
                return true;
            }

            return false;
        }

        public void CapturePlayers()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("Enter player one name");
            Console.Write("-> ");
            Player1 = Console.ReadLine().Trim();
            Console.WriteLine();
            Console.WriteLine("Enter player two name");
            Console.Write("-> ");
            Player2 = Console.ReadLine().Trim();
            Console.WriteLine("------------------------- WELCOME! --------------------------");
            Console.WriteLine(); 
            Console.WriteLine();
            GameRules();
        }

        public void GameRules()
        {
            Console.WriteLine("-------------------------- RULES ----------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Only use numbers from 1 - 9");
            Console.WriteLine("2. The number entered number populate a position on the board");
            Console.WriteLine("3. You cannot choose a position taken by the other player");
            Console.WriteLine();
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.Write("Loading game...");
            Thread.Sleep(4000);
            Console.Clear();
        }

        public void RestartGame()
        {
            var positionValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            PositionValues = positionValues;
            Console.Clear();
            CapturePlayers();
            CreateBoard();
        }

        public bool GetPlayerInput(string player)
        {
            string playerInput;
            bool nextPlayer;

            Console.Write($"{player}: Choose your position! : ");
            playerInput = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(playerInput))
            {
                nextPlayer = CheckAndInsertInput(playerInput, player);
            }
            else
            {
                nextPlayer = false;
            }

            return nextPlayer;
        }

        public bool CheckAndInsertInput(string playerInput, string player)
        {
            var validInput = false;

            var p1Char = "X";
            var p2Char = "O";

            while (!validInput)
            {
                if (PositionValues.Contains(playerInput) && Player1 == player)
                {
                    PositionValues[Array.IndexOf(PositionValues, playerInput)] = p1Char;
                    validInput = true;
                }
                else if (PositionValues.Contains(playerInput) && Player2 == player)
                {
                    PositionValues[Array.IndexOf(PositionValues, playerInput)] = p2Char;
                    validInput = true;
                }
                else if (!PositionValues.Contains(playerInput))
                {
                    Console.WriteLine("Position is already taken!");
                    validInput = false;
                    GetPlayerInput(player);
                }
                else
                {
                    Console.WriteLine("Invalid entry! Please enter a valid position.");
                    validInput = false;
                    GetPlayerInput(player);
                }
            }

            return validInput;
        }
    }
}
