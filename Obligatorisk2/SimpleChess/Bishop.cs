using System;

namespace SimpleChess
{
    class Bishop : Piece
    {
        public Bishop() : base("bishop")
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}