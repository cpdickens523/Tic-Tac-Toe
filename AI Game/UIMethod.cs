using System;

namespace MyApp
{
    internal static class UIMethod
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to playing tic-tac-toe against AI!");
        }
        public static int GetUserChoice()
        {
            Console.WriteLine("Enter 1 for X and O");
            Console.WriteLine("Enter 2 for numbers");
            Console.WriteLine("Enter 3 for OTHER");
            
            string input = Console.ReadLine();
            int choice;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                input = Console.ReadLine();
            }

            return choice;
        }
        public static void DisplayBoard(int[,] theBoard, int mode)
        {
            DisplayGrid(theBoard, mode);
        }
        
        public static void DisplayGrid(int[,] grid, int mode)
        {
            string border = new string('#', (grid.GetLength(1) * 4) + 2);
            Console.WriteLine(border);

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                Console.Write("#");
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    string cell = Logic.GetCellDisplay(grid[i, j], mode);
                    Console.Write(cell.PadLeft(4));
                }
                Console.WriteLine("#");
            }

            Console.WriteLine(border);
        }
    }
}



        
    

