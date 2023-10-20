using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;
using Console_Chess.Chessboard.Exceptions;

namespace Console_Chess.Chess
{
    class Rook : Piece
    {
        public Rook(Board Board, Color Color) : base(Board, Color)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
