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

            internal static bool CheckVertical(int[,] board, int player)
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

            internal static bool CheckDiagonal(int[,] board, int player)
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






