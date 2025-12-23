using System;

namespace MyApp
{
    internal static class UIMethod
    {
       
        private const int MinDisplayMode = 1;
        private const int MaxDisplayMode = 3;

       
        private const char BorderChar = '#';
        private const int CellWidth = 4;

       
        private const string WelcomeMessage = "Welcome to Tic-Tac-Toe against AI!";
        private const string InvalidInputMessage = "Invalid input. Enter 1, 2, or 3.";

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine(WelcomeMessage);
        }

        public static int GetUserChoice()
        {
            Console.WriteLine("Choose display mode:");
            Console.WriteLine("1 - X and O");
            Console.WriteLine("2 - Numbers");
            Console.WriteLine("3 - Alternate mode");

            string input = Console.ReadLine();
            int choice;

            while (!int.TryParse(input, out choice) ||
                   choice < MinDisplayMode ||
                   choice > MaxDisplayMode)
            {
                Console.WriteLine(InvalidInputMessage);
                input = Console.ReadLine();
            }

            return choice;
        }

        public static void DisplayBoard(int[,] board, int mode)
        {
            int columns = board.GetLength(1);
            string border = new string(BorderChar, (columns * CellWidth) + 2);

            Console.WriteLine(border);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(BorderChar);

                for (int j = 0; j < columns; j++)
                {
                    string cell = Logic.GetCellDisplay(board[i, j], mode);
                    Console.Write(cell.PadLeft(CellWidth));
                }

                Console.WriteLine(BorderChar);
            }

            Console.WriteLine(border);
        }
    }
}




        
    

