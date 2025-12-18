using System;

namespace MyApp
{
    internal static class Logic
    {
        public static int[,] GenerateEmptyBoard(int width, int height)
        {
            return new int[width, height];
        }

        public static string GetCellDisplay(int value, int mode)
        {
            if (value == 0) return " ";
            if (mode == 1) return value == 1 ? "X" : "O";
            if (mode == 2) return value.ToString();
            if (mode == 3) return value == 1 ? "O" : "X";
            return "?";
        }

        public static bool PlacePiece(int[,] board, int row, int col, int player)
        {
            if (board[row, col] != 0) return false;
            board[row, col] = player;
            return true;
        }

        public static bool CheckWin(int[,] board, int player)
        {
            int size = board.GetLength(0);

          
            for (int i = 0; i < size; i++)
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    return true;

            
            for (int j = 0; j < size; j++)
                if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
                    return true;

           
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) return true;
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) return true;

            return false;
        }

        public static bool IsDraw(int[,] board)
        {
            foreach (int cell in board)
                if (cell == 0) return false;
            return true;
        }
    }
}




