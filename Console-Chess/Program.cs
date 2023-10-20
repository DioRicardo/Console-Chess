using System;
using Console_Chess.Chess;
using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;
using Console_Chess.Chessboard.Exceptions;

namespace Console_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.SetPiece(new Rook(board, Color.Black), new Position(0, 0));
                board.SetPiece(new Rook(board, Color.Black), new Position(1, 3));
                board.SetPiece(new King(board, Color.Black), new Position(0, 2));

                Screen.PrintBoardOnScreen(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }           


        }
    }
}
