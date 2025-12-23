using System;

namespace MyApp
{
    internal class Program
    {
       
        private const int BoardSize = 3;

        
        private const int PlayerOne = 1;
        private const int PlayerTwo = 2;

       
        private const int MinIndex = 0;
        private const int MaxIndex = BoardSize - 1;

        static void Main(string[] args)
        {
            UIMethod.DisplayWelcomeMessage();

            int mode = UIMethod.GetUserChoice();
            int[,] board = Logic.GenerateEmptyBoard(BoardSize, BoardSize);

            int currentPlayer = PlayerOne;
            bool gameOver = false;

            Random rng = new Random();

            while (!gameOver)
            {
                UIMethod.DisplayBoard(board, mode);

                if (currentPlayer == PlayerOne)
                {
                    int row, col;

                    while (true)
                    {
                        Console.Write($"Enter row ({MinIndex}-{MaxIndex}): ");
                        row = int.Parse(Console.ReadLine());

                        Console.Write($"Enter col ({MinIndex}-{MaxIndex}): ");
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
                        row = rng.Next(MinIndex, BoardSize);
                        col = rng.Next(MinIndex, BoardSize);
                    }
                    while (!Logic.PlacePiece(board, row, col, currentPlayer));

                    Console.WriteLine($"AI placed at {row},{col}");
                }

                if (Logic.CheckWin(board, currentPlayer))
                {
                    UIMethod.DisplayBoard(board, mode);

                    string winner = currentPlayer == PlayerOne ? "You" : "AI";
                    Console.WriteLine($"{winner} win!");

                    gameOver = true;
                }
                else if (Logic.IsDraw(board))
                {
                    UIMethod.DisplayBoard(board, mode);
                    Console.WriteLine("Draw!");
                    gameOver = true;
                }

                currentPlayer = currentPlayer == PlayerOne
                    ? PlayerTwo
                    : PlayerOne;
            }
        }
    }
}
