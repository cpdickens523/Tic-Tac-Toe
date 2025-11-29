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
    }

    // Moved all THIS into its own method so it's in scope:
    public static void GenerateBoard()
    {
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

        int userChoice;
        if (!int.TryParse(Console.ReadLine(), out userChoice))
        {
            Console.WriteLine("Invalid input. Please restart and enter 1, 2, or 3.");
            return;
        }

        int[,] numbers = new int[threeRows, threeColumns];

        Console.WriteLine($"A random row will generate: {threeRows}");
        Console.WriteLine($"A random column will generate: {threeColumns}");
        Console.WriteLine("Here is your 2D array:");
        Console.WriteLine(verticalBorder);

        for (int i = 0; i < threeRows; i++)
        {
            Console.Write("#");
            for (int j = 0; j < threeColumns; j++)
            {
                numbers[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
                Console.Write(numbers[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine(" #");
        }
        Console.WriteLine(verticalBorder);
    }
}


        
    

