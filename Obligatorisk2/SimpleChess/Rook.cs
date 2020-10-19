using System;

namespace SimpleChess
{
    class Rook : Piece
    {
        public Rook() : base("rook")
        {

        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}