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
            PositionChess pos = new PositionChess('a', 8);
            
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosition());

        }
    }
}
