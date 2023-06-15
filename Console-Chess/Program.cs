using System;
using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;

namespace Console_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);


            Screen.PrintBoardOnScreen(board);


        }
    }
}
