using System;
using System.Drawing;
using Console_Chess.Chessboard;
using Console_Chess.Chessboard.Enums;

namespace Console_Chess.Chess
{
    internal class ChessMatch
    {
        
        private int Turn;
        private Color CurrentPlayer;
        public Board Board { get; private set; }
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            Finished = false;
            SetPieces();
        }

        public void ExecuteMove(Position origin, Position target)
        {
            Piece p = Board.RemovePiece(origin);
            p.IncrementQntMovement();
            Piece CapturedPiece = Board.RemovePiece(target);
            Board.SetPiece(p, target);
        }

        private void SetPieces()
        {
            Board.SetPiece(new Rook(Board, ChessColors.White), new PositionChess('c', 1).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.White), new PositionChess('c', 2).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.White), new PositionChess('d', 2).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.White), new PositionChess('e', 2).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.White), new PositionChess('e', 1).ToPosition());
            Board.SetPiece(new King(Board, ChessColors.White), new PositionChess('d', 1).ToPosition());


            Board.SetPiece(new Rook(Board, ChessColors.Black), new PositionChess('c', 7).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.Black), new PositionChess('c', 8).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.Black), new PositionChess('d', 7).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.Black), new PositionChess('e', 7).ToPosition());
            Board.SetPiece(new Rook(Board, ChessColors.Black), new PositionChess('e', 8).ToPosition());
            Board.SetPiece(new King(Board, ChessColors.Black), new PositionChess('d', 8).ToPosition());

        }
    }
}
