using Console_Chess.Chessboard.Enums;
using Console_Chess.Chessboard.Exceptions;

namespace Console_Chess.Chessboard
{
    class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int line, int column)
        {
            Row = line;
            Column = column;
        }

        public override string ToString()
        {
            return Row + ", " + Column;
        }
    }
}
