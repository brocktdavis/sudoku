using lib;
using System.Collections.Generic;

namespace sudoku
{
    public class SudokuCell : AbstractCell
    {
        public SudokuCell(int r, int c) : base(r, c) {}
        public SudokuCell(int r, int c, char v) : base(r, c, v) {}
        public SudokuCell(Pair<int> loc) : base(loc) {}
        public SudokuCell(Pair<int> loc, char v) : base(loc, v) {}
        public SudokuCell(AbstractCell o) : base(o) {}

        public override List<Pair<int>> sees()
        {
            List<Pair<int>> ret = new List<Pair<int>>();
            
            // Loops through each row that's not this own
            for (int r = 1; r <= 9 && r != this.r; r++)
            {
                Pair<int> p = new Pair<int>(r, this.c);
                ret.Add(p);
            }

            // Loops through each col that's not this own
            for (int c = 1; c <= 9 && c != this.c; c++)
            {
                Pair<int> p = new Pair<int>(this.r, c);
                ret.Add(p);
            }

            return ret;
        }
    }
}