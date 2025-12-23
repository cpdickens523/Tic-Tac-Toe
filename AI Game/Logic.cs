using System;

namespace MyApp
{
    internal static class Logic
    {
        private const int EmptyCell = 0;
        private const int PlayerOne = 1;
        private const int PlayerTwo = 2;

       
        private const int ModeXO = 1;
        private const int ModeNumbers = 2;
        private const int ModeReversedXO = 3;

        
        private const int WinLength = 3;

        public static int[,] GenerateEmptyBoard(int width, int height)
        {
            return new int[width, height];
        }

        public static string GetCellDisplay(int value, int mode)
        {
            if (value == EmptyCell) return " ";

            return mode switch
            {
                ModeXO => value == PlayerOne ? "X" : "O",
                ModeNumbers => value.ToString(),
                ModeReversedXO => value == PlayerOne ? "O" : "X",
                _ => "?"
            };
        }

        public static bool PlacePiece(int[,] board, int row, int col, int player)
        {
            if (board[row, col] != EmptyCell) return false;

            board[row, col] = player;
            return true;
        }

        public static bool CheckWin(int[,] board, int player)
        {
            int size = board.GetLength(0);

          
            for (int i = 0; i < size; i++)
                if (board[i, 0] == player &&
                    board[i, 1] == player &&
                    board[i, 2] == player)
                    return true;

          
            for (int j = 0; j < size; j++)
                if (board[0, j] == player &&
                    board[1, j] == player &&
                    board[2, j] == player)
                    return true;

            
            if (board[0, 0] == player &&
                board[1, 1] == player &&
                board[2, 2] == player)
                return true;

            if (board[0, 2] == player &&
                board[1, 1] == player &&
                board[2, 0] == player)
                return true;

            return false;
        }

        public static bool IsDraw(int[,] board)
        {
            foreach (int cell in board)
                if (cell == EmptyCell)
                    return false;

            return true;
        }
    }
}




