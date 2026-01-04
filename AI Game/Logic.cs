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
            if (board[row, col] != EmptyCell)
                return false;

            board[row, col] = player;
            return true;
        }

        public static bool CheckWin(int[,] board, int player)
        {
            return CheckHorizontal(board, player)
                || CheckVertical(board, player)
                || CheckDiagonal(board, player);
        }

        private static bool CheckHorizontal(int[,] board, int player)
        {
            int size = board.GetLength(0);

            for (int row = 0; row < size; row++)
            {
                if (board[row, 0] == player &&
                    board[row, 1] == player &&
                    board[row, 2] == player)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckVertical(int[,] board, int player)
        {
            int size = board.GetLength(1);

            for (int col = 0; col < size; col++)
            {
                if (board[0, col] == player &&
                    board[1, col] == player &&
                    board[2, col] == player)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckDiagonal(int[,] board, int player)
        {
            if (board[0, 0] == player &&
                board[1, 1] == player &&
                board[2, 2] == player)
            {
                return true;
            }
            if (board[0, 2] == player &&
                board[1, 1] == player &&
                board[2, 0] == player)
            {
                return true;
            }

            return false;
        }

        public static bool IsDraw(int[,] board)
        {
            foreach (int cell in board)
            {
                if (cell == EmptyCell)
                    return false;
            }

            return true;
        }
    }
}





