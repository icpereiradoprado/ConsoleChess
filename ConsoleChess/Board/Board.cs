using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.board
{
    class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        
        private Piece[,] Pieces;

        public Board(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines,Columns];
        }
        
        public Piece piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public void putPiece(Piece piece, Position position)
        {
            Pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

    }
}
