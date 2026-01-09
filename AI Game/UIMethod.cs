using System;

namespace MyApp
{
    internal static class UIMethod
    {
        private const int MIN_DISPLAY_MODE = 1;
        private const int MAX_DISPLAY_MODE = 3;

       
        private const char BORDER_CHAR = '#';
        private const int CELL_WIDTH = 4;

       
        private const string WELCOME_MESSAGE = "Welcome to Tic-Tac-Toe against AI!";
        private const string INVALID_INPUT_MESSAGE = "Invalid input. Enter 1, 2, or 3.";

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine(WELCOME_MESSAGE);
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
                   choice < MIN_DISPLAY_MODE ||
                   choice > MAX_DISPLAY_MODE)
            {
                Console.WriteLine(INVALID_INPUT_MESSAGE);
                input = Console.ReadLine();
            }

            return choice;
        }

        public static void DisplayBoard(int[,] board, int mode)
        {
            int columns = board.GetLength(1);
            string border = new string(BORDER_CHAR, (columns * CELL_WIDTH) + 2);

            Console.WriteLine(border);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(BORDER_CHAR);

                for (int j = 0; j < columns; j++)
                {
                    string cell = Logic.GetCellDisplay(board[i, j], mode);
                    Console.Write(cell.PadLeft(CELL_WIDTH));
                }

                Console.WriteLine(BORDER_CHAR);
            }

            Console.WriteLine(border);
        }
    }
}




        
    

