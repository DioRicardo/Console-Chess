using System;
using Console_Chess.Chessboard;

namespace Console_Chess.Chess
{
    class PositionChess
    {
        public char Column { get; set; }
        public int Row { get; set; }

        public PositionChess(char column, int row)
        {
            Column = column;
            Row = row;
        }

        public Position ToPosition()
        {
            return new Position(8 - Row, Column - 'a');
        }

        public override string ToString()
        {
            return "" + Column + Row;
        }



    }
}
