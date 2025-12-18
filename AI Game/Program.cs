using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] board = Logic.GenerateBoard(3, 3);

            
            int mode = UIMethod.GetUserChoice();
            
            UIMethod.DisplayBoard(board, mode);
        }
    }
}