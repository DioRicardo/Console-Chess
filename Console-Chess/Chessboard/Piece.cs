using Console_Chess.Chessboard.Enums;

namespace Console_Chess.Chessboard
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumOfMovement { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Position position, Board board, Color color)
        {
            Position = position;
            Color = color;
            Board = board;
            NumOfMovement = 0;
        }
    }
}
