
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
int[,] numbers = new int[threeRows, threeColumns];
int userChoice = int.Parse(Console.ReadLine());

for (int i = 0; i < threeRows; i++)
{
    for (int j = 0; j < threeColumns; j++)
    {
        numbers[i, j] = rng.Next(LOW_NUMBER, HIGH_NUMBER);
    }
}
for (int i = 0; i < threeRows; i++)

for (int j = 0; j < threeColumns; j++)

    else if (userChoice == OTHER_VARIABLE)
    
    for (int i = 0; i < threeRows; i++)
    
    for (int j = 0; j < threeColumns; j++)
    {
        if (numbers[i, j] % 2 == 1)
        
            for (int i = 0; i < threeRows; i++)
            
            for (int j = 0; j < threeColumns; j++)
            
                if (numbers[i, j] % 2 == 0)
                
                    else if (userChoice == NUMBER_VARIABLE)
                    
            string horizontalBorder = new string('#', (threeColumns * 4) + 2);
        string verticalBorder = new string('#', (threeRows * 4) + 2);

        if (userChoice == SYMBOL_VARIABLE)