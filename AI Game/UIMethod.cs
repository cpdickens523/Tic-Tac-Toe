namespace MyApp
{
    internal static class UIMethod
    {
        


        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to playing tictactoe against AI!");
        }

        public static bool MakeDecision()
        {
            Console.WriteLine("Do you want to play?");
            if (Console.ReadLine() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }

            Random rng = new Random();
            const int LOW_NUMBER = 1;
            const int HIGH_NUMBER = 3;
            const int ARRAY_FIGURE_1 = 0;
            const int ARRAY_FIGURE_2 = 0;
            const int SYMBOL_VARIABLE = 1;
            const int NUMBER_VARIABLE = 2;
            const int OTHER_VARIABLE = 3;

            int threeRows = LOW_NUMBER * HIGH_NUMBER;
            int threeColumns = LOW_NUMBER * HIGH_NUMBER;
            string horizontalBorder = new string('#', (threeColumns * 4) + 2);
            string verticalBorder = new string('#', (threeRows * 4) + 2);

            Console.WriteLine($"Enter {SYMBOL_VARIABLE} for X and O");
            Console.WriteLine($"Please enter {NUMBER_VARIABLE} for numbers");
            Console.WriteLine($"Enter {OTHER_VARIABLE} for OTHER");
            int userChoice = int.Parse(Console.ReadLine());
            int[,] numbers = new int[threeRows, threeColumns];

            for (int i = 0; i < threeRows; i++)
            {
                for (int j = 0; j < threeColumns; j++)

                    numbers[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                Console.Write(numbers[i, j].ToString().PadLeft(4));

                Console.WriteLine($"A random row will generate: {threeRows}");
                Console.WriteLine($"A random column will generate: {threeColumns}");
                Console.WriteLine("Here is your 2D array:");
                Console.WriteLine(verticalBorder);
                Console.Write("#");
                Console.Write(ARRAY_FIGURE_2);
                Console.Write(ARRAY_FIGURE_1);
                Console.WriteLine("#");
                Console.WriteLine(horizontalBorder);
                Console.WriteLine(horizontalBorder);
                Console.Write("#");
                Console.Write("#");
                Console.Write(numbers[i, j].ToString().PadLeft(4));
                Console.WriteLine("#");
                Console.WriteLine(horizontalBorder);
                Console.WriteLine(horizontalBorder);
                Console.Write("#");
                Console.Write("#");
                Console.Write(ARRAY_FIGURE_2);
                Console.Write(ARRAY_FIGURE_1);
                Console.WriteLine("#");
                Console.WriteLine(horizontalBorder);
                Console.WriteLine("Invalid input. Please restart and enter 1 or 2.");
            }
        }
    }
}
        
    

