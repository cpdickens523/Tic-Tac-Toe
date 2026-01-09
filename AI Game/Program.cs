using System;
using System.Runtime.Intrinsics.X86;

namespace MyApp
{
    internal class Program
    {
       
        private const int BOARD_SIZE = 3;

        
        private const int PLAYER_ONE = 1;
        private const int PLAYER_TWO = 2;

       
        private const int MIN_INDEX = 0;
        private const int MAX_INDEX = BOARD_SIZE - 1;

        static void Main(string[] args)
        {
            UIMethod.DisplayWelcomeMessage();

            int mode = UIMethod.GetUserChoice();
            int[,] board = Logic.GenerateEmptyBoard(BOARD_SIZE, BOARD_SIZE);

            int currentPlayer = PLAYER_ONE;
            bool gameOver = false;

            Random rng = new Random();

            while (!gameOver)
            {
                UIMethod.DisplayBoard(board, mode);

                if (currentPlayer == PLAYER_ONE)
                {
                    int row, col;

                    while (true)
                    {
                        Console.Write($"Enter row ({MIN_INDEX}-{MAX_INDEX}): ");
                        row = int.Parse(Console.ReadLine());

                        Console.Write($"Enter col ({MIN_INDEX}-{MAX_INDEX}): ");
                        col = int.Parse(Console.ReadLine());

                        if (Logic.PlacePiece(board, row, col, currentPlayer))
                            break;

                        Console.WriteLine("Cell already filled. Try again.");
                    }
                }
                else
                {
                    int row, col;

                    do
                    {
                        row = rng.Next(MIN_INDEX, BOARD_SIZE);
                        col = rng.Next(MIN_INDEX, BOARD_SIZE);
                    }
                    while (!Logic.PlacePiece(board, row, col, currentPlayer));

                    Console.WriteLine($"AI placed at {row},{col}");
                }

                if (Logic.CheckWin(board, currentPlayer))
                {
                    UIMethod.DisplayBoard(board, mode);

                    string winner = currentPlayer == PLAYER_ONE ? "You" : "AI";
                    Console.WriteLine($"{winner} win!");

                    gameOver = true;
                }
                else if (Logic.IsDraw(board))
                {
                    UIMethod.DisplayBoard(board, mode);
                    Console.WriteLine("Draw!");
                    gameOver = true;
                }

                currentPlayer = currentPlayer == PLAYER_ONE
                    ? PLAYER_TWO
                    : PLAYER_ONE;
            }
        }
    }
}
