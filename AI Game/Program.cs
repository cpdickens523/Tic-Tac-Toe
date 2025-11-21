// See https://aka.ms/new-console-template for more information

        using System;

        namespace MyApp
        {
            internal class Program
            {
                static void Main(string[] args)
                {
                    UIMethod.DisplayWelcomeMessage();

                    if (UIMethod.MakeDecision() == false)
                    {
                        Environment.Exit(0);
                    }
                    Random rng = new Random();
                    const int LOW_NUMBER = 1;
                    const int HIGH_NUMBER = 3;
                    const string ARRAY_FIGURE_1 = "X";
                    const string ARRAY_FIGURE_2 = "O";
                    const int SYMBOL_VARIABLE = 1;
                    const int NUMBER_VARIABLE = 2;
                    const int OTHER_VARIABLE = 3;

                    int threeRows = LOW_NUMBER * HIGH_NUMBER;
                    int threeColumns = LOW_NUMBER * HIGH_NUMBER;

                    Console.WriteLine($"Enter {SYMBOL_VARIABLE} for X and O");
                    Console.WriteLine($"Please enter {NUMBER_VARIABLE} for numbers");
                    Console.WriteLine($"Enter {OTHER_VARIABLE} for OTHER");
                    int userChoice = int.Parse(Console.ReadLine());

                    Console.WriteLine($"A random row will generate: {threeRows}");
                    Console.WriteLine($"A random column will generate: {threeColumns}");

                    int[,] numbers = new int[threeRows, threeColumns];



                    if (userChoice == SYMBOL_VARIABLE)
                    {

                        for (int i = 0; i < threeRows; i++)
                        {


                            for (int j = 0; j < threeColumns; j++)
                            {
                                if (numbers[i, j] % 2 == 0)
                                {

                                }
                                else
                                {

                                }
                            }


                        }

                    }
                    else if (userChoice == NUMBER_VARIABLE)
                    {


                        for (int i = 0; i < threeRows; i++)
                        {
                            for (int j = 0; j < threeColumns; j++)
                            {

                            }

                        }


                    }

                    else if (userChoice == OTHER_VARIABLE)
                    {



                        for (int i = 0; i < threeRows; i++)
                        {

                            for (int j = 0; j < threeColumns; j++)
                            {
                                if (numbers[i, j] % 2 == 1)
                                {

                                }
                            }

                        }
                    }
                }
            }
        }
        

  