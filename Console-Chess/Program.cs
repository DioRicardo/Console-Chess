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
                
                ChessMatch chessMatch = new ChessMatch();
                               
                while (!chessMatch.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoardOnScreen(chessMatch.Board);

                    Console.WriteLine();

                    Console.Write("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();
                    Console.Write("Target: ");
                    Position target = Screen.ReadChessPosition().ToPosition();

                    chessMatch.ExecuteMove(origin, target);

                }

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
