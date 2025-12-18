using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIMethod.DisplayWelcomeMessage();

            int mode = UIMethod.GetUserChoice();
            int[,] board = Logic.GenerateEmptyBoard(3, 3);
            int currentPlayer = 1; 
            bool gameOver = false;

            Random rng = new Random();

            while (!gameOver)
            {
                UIMethod.DisplayBoard(board, mode);

                if (currentPlayer == 1) 
                {
                    int row, col;
                    while (true)
                    {
                        Console.Write("Enter row (0-2): ");
                        row = int.Parse(Console.ReadLine());
                        Console.Write("Enter col (0-2): ");
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
                        row = rng.Next(0, 3);
                        col = rng.Next(0, 3);
                    } while (!Logic.PlacePiece(board, row, col, currentPlayer));

                    Console.WriteLine($"AI placed at {row},{col}");
                }

                // Check win/draw
                if (Logic.CheckWin(board, currentPlayer))
                {
                    UIMethod.DisplayBoard(board, mode);
                    string winner = currentPlayer == 1 ? "You" : "AI";
                    Console.WriteLine($"{winner} win!");
                    gameOver = true;
                }
                else if (Logic.IsDraw(board))
                {
                    UIMethod.DisplayBoard(board, mode);
                    Console.WriteLine("Draw!");
                    gameOver = true;
                }

                currentPlayer = currentPlayer == 1 ? 2 : 1; 
            }
        }
    }
}
