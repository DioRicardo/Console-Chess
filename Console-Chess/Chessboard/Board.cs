using Console_Chess.Chessboard.Enums;
using Console_Chess.Chessboard.Exceptions;

namespace Console_Chess.Chessboard
{
    class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        private Piece[,] Pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece Piece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece Piece(Position pos)
        {
            return Pieces[pos.Row, pos.Column];
        }

        public bool PieceExists(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        public void SetPiece(Piece p, Position pos)
        {
            if(PieceExists(pos))
            {
                throw new BoardException("There is already a piece in that position!");
            }

            Pieces[pos.Row, pos.Column] = p;
            p.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if(Piece(pos) == null)
            {
                return null;
            }
            Piece aux = Piece(pos);
            aux.Position = null;
            Pieces[pos.Row, pos.Column] = null;
            return aux;
        }

        public bool ValidPosition(Position pos)
        {
            if(pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if(!ValidPosition(pos))
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
