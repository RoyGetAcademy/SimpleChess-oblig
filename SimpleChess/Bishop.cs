using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    internal class Bishop : Piece
    {
        public Bishop() : base("LPR") { }

        public override bool Move(string fromPosition, string toPosition)
        {
            var col = fromPosition[0] - toPosition[0];
            var row = fromPosition[1] - toPosition[1];

            return Math.Abs(row) == Math.Abs(col);
        }
    }

}
