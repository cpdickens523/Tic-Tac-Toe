using System;

namespace MyApp
{
    internal static class Logic
    {
        public static int[,] GenerateBoard(int width, int height)
        {
            Random rng = new Random();
            int[,] board = new int[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    board[i, j] = rng.Next(1, 3);
                }
            }

            return board;
        }
        public static string GetCellDisplay(int value, int mode)
        {
            if (mode == 1)
                return value % 2 == 0 ? "O" : "X";

            if (mode == 2)
                return value.ToString();

            if (mode == 3)
                return value % 2 == 1 ? "O" : "X";

            return "?";
        }
    }
}

