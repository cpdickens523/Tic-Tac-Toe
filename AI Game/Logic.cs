using System;

namespace MyApp
{
    public static class Logic
    {
        private const int EMPTY_CELL = 0;
        private const int PLAYER_ONE = 1;
        private const int PLAYER_TWO = 2;

        private const int MODE_XO = 1;
        private const int MODE_NUMBERS = 2;
        private const int MODE_REVERSED_XO = 3;

        private const int WIN_LENGTH = 3; 
        private const int CHECK_ONE = 'X';
        private const int CHECK_TWO = 'O';

        public static int[,] GenerateEmptyBoard(int width, int height)
        {
            return new int[width, height];
        }

        public static string GetCellDisplay(int value, int mode)
        {
            if (value == EMPTY_CELL)
                return " ";

            return mode switch
            {
                MODE_XO => value == PLAYER_ONE ? CHECK_ONE.ToString() : CHECK_TWO.ToString(),
                MODE_NUMBERS => value.ToString(),
                MODE_REVERSED_XO => value == PLAYER_ONE ? CHECK_TWO.ToString() : CHECK_ONE.ToString(),
                _ => "?"
            };
        }

        public static bool PlacePiece(int[,] board, int row, int col, int player)
        {
            if (board[row, col] != EMPTY_CELL)
                return false;

            board[row, col] = player;
            return true;
        }

        internal static bool CheckWin(int[,] board, int player)
        {
            return CheckHorizontal(board, player)
                   || CheckVertical(board, player)
                   || CheckDiagonal(board, player);
        }

        internal static bool CheckHorizontal(int[,] board, int player)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int startCol = 0; startCol <= cols - WIN_LENGTH; startCol++)
                {
                    bool rowWin = true;

                    for (int j = 0; j < WIN_LENGTH; j++)
                    {
                        if (board[i, startCol + j] != player)
                        {
                            rowWin = false;
                            break;
                        }
                    }

                    if (rowWin)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        internal static bool CheckVertical(int[,] board, int player)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row <= rows - WIN_LENGTH; row++)
                {
                    bool win = true;
                    for (int k = 0; k < WIN_LENGTH; k++)
                    {
                        if (board[row + k, col] != player)
                        {
                            win = false;
                            break;
                        }
                    }
                    if (win) return true;
                }
            }
            return false;
        }

        internal static bool CheckDiagonal(int[,] board, int player)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            
            for (int row = 0; row <= rows - WIN_LENGTH; row++)
            {
                for (int col = 0; col <= cols - WIN_LENGTH; col++)
                {
                    bool win = true;
                    for (int k = 0; k < WIN_LENGTH; k++)
                    {
                        if (board[row + k, col + k] != player)
                        {
                            win = false;
                            break;
                        }
                    }
                    if (win) return true;
                }
            }
            
            for (int row = 0; row <= rows - WIN_LENGTH; row++)
            {
                for (int col = WIN_LENGTH - 1; col < cols; col++)
                {
                    bool win = true;
                    for (int k = 0; k < WIN_LENGTH; k++)
                    {
                        if (board[row + k, col - k] != player)
                        {
                            win = false;
                            break;
                        }
                    }
                    if (win) return true;
                }
            }

            return false;
        }

        internal static bool IsDraw(int[,] board)
        {
            foreach (int cell in board)
            {
                if (cell == EMPTY_CELL)
                    return false;
            }
            return true;
        }
    }
}






