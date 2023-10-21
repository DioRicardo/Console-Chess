using System;
using Console_Chess.Chess;
using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;
using Console_Chess.Chessboard.Exceptions;

namespace Console_Chess
{
    class Screen
    {
        public static void PrintBoardOnScreen(Board board)
        {
            for (int i = 0; i < board.Rows;  i++)
            {
                Console.Write(8 -  i + " ");

                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static PositionChess ReadChessPosition()
        {
            string s = Console.ReadLine();
            char Column = s[0];
            int Row = int.Parse(s[1] + "");
            return new PositionChess(Column, Row);
        }
        

        public static void PrintPiece(Piece piece)
        {
            if(piece.ChessColors == ChessColors.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
