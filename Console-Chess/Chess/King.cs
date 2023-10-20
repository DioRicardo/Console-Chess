using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;

namespace Console_Chess.Chess
{
    class King : Piece
    {
        public King(Board Board, Color Color) : base(Board, Color)
        {

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
