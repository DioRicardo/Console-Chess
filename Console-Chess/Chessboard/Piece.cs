using Console_Chess.Chessboard.Enums;
using Console_Chess.Chessboard.Exceptions;

namespace Console_Chess.Chessboard
{
    class Piece
    {
        public Position Position { get; set; }
        public ChessColors ChessColors { get; protected set; }
        public int QntMovement { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, ChessColors color)
        {
            Position = null;
            ChessColors = color;
            Board = board;
            QntMovement = 0;
        }

        public void IncrementQntMovement()
        {
            QntMovement++;
        }
    }
}
