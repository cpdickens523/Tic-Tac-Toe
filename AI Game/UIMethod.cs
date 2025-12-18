using System;

namespace MyApp
{
    internal static class UIMethod
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe against AI!");
        }

        public static int GetUserChoice()
        {
            Console.WriteLine("Choose display mode:");
            Console.WriteLine("1 - X and O");
            Console.WriteLine("2 - Numbers");
            Console.WriteLine("3 - Alternate mode");

            string input = Console.ReadLine();
            int choice;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Enter 1, 2, or 3.");
                input = Console.ReadLine();
            }

            return choice;
        }

        public static void DisplayBoard(int[,] board, int mode)
        {
            string border = new string('#', (board.GetLength(1) * 4) + 2);
            Console.WriteLine(border);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("#");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    string cell = Logic.GetCellDisplay(board[i, j], mode);
                    Console.Write(cell.PadLeft(4));
                }
                Console.WriteLine("#");
            }

            Console.WriteLine(border);
        }
    }
}




        
    

