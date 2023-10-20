using System;
using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;

namespace Console_Chess
{
    class Screen
    {
        public static void PrintBoardOnScreen(Board board)
        {
            for (int i = 0; i < board.Rows;  i++)
            {
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(i, j) + " ");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
