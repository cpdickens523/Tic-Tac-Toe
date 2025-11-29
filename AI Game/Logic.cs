public static void ProcessUserChoice()
{
    Random rng = new Random();
    const int LOW_NUMBER = 1;
    const int HIGH_NUMBER = 3;
    const int SYMBOL_VARIABLE = 1;
    const int NUMBER_VARIABLE = 2;
    const int OTHER_VARIABLE = 3;

    int threeRows = LOW_NUMBER * HIGH_NUMBER;
    int threeColumns = LOW_NUMBER * HIGH_NUMBER;

    int[,] numbers = new int[threeRows, threeColumns];

    Console.WriteLine($"Enter {SYMBOL_VARIABLE} for X and O");
    Console.WriteLine($"Enter {NUMBER_VARIABLE} for numbers");
    Console.WriteLine($"Enter {OTHER_VARIABLE} for OTHER");
    int userChoice = int.Parse(Console.ReadLine());

    // Fill array with random numbers
    for (int i = 0; i < threeRows; i++)
    {
        for (int j = 0; j < threeColumns; j++)
        {
            numbers[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
        }
    }

    // Create borders
    string horizontalBorder = new string('#', (threeColumns * 4) + 2);
    string verticalBorder = new string('#', (threeRows * 4) + 2);

    Console.WriteLine(horizontalBorder);

    // Process user choice
    if (userChoice == SYMBOL_VARIABLE) // X and O
    {
        for (int i = 0; i < threeRows; i++)
        {
            Console.Write("#");
            for (int j = 0; j < threeColumns; j++)
            {
                char symbol = numbers[i, j] % 2 == 0 ? 'X' : 'O';
                Console.Write($" {symbol}  ");
            }
            Console.WriteLine("#");
        }
    }
    else if (userChoice == NUMBER_VARIABLE) // Print numbers
    {
        for (int i = 0; i < threeRows; i++)
        {
            Console.Write("#");
            for (int j = 0; j < threeColumns; j++)
            {
                Console.Write(numbers[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine(" #");
        }
    }
    else if (userChoice == OTHER_VARIABLE) // Odd/Even Labels
    {
        for (int i = 0; i < threeRows; i++)
        {
            Console.Write("#");
            for (int j = 0; j < threeColumns; j++)
            {
                string output = numbers[i, j] % 2 == 0 ? "EVEN" : "ODD";
                Console.Write(output.PadLeft(5));
            }
            Console.WriteLine(" #");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please restart and enter 1, 2, or 3.");
        return;
    }

    Console.WriteLine(horizontalBorder);
}
