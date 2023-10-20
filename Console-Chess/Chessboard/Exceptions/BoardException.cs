using System;

namespace Console_Chess.Chessboard.Exceptions
{
    internal class BoardException : Exception
    {
        public BoardException(string msg) : base(msg) { }
    }
}
