using Console_Chess.Chessboard.Enums;

namespace Console_Chess.Chessboard
{
    class Board
    {
        public int Rows { get; set; }
        public int Column { get; set; }

        private Piece[,] Pieces;

        public Board(int rows, int column)
        {
            Rows = rows;
            Column = column;
            Pieces = new Piece[rows, column];
        }
    }
}
