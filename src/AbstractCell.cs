using System;
using lib;
using System.Collections.Generic;

namespace sudoku
{
    public abstract class AbstractCell
    {
        private int _r;
        private int _c;
        private char _v = ' ';


        // Initialization constructors
        public AbstractCell(int r, int c)
        {
            _r = r;
            _c = c;
        }

        public AbstractCell(int r, int c, char v) : this (r, c)
        {
            _v = v;
        }

        public AbstractCell(Pair<int> loc) : this(loc.first, loc.second) {}

        public AbstractCell(Pair<int> loc, char v) : this(loc.first, loc.second, v) {}

        // Copy constructor
        public AbstractCell(AbstractCell o) : this(o.r, o.c, o.v) {}

        // Getters
        public char v { get { return _v; } }
        public int r { get { return _r; } }
        public int c { get { return _c; } }

        // ToSring
        // Outputs something like (1, 4, 'b')
        public override String ToString()
        {
            return "(" + _r + ", " + _c + ", '" + _v + "')";
        }

        public abstract List<Pair<int>> sees();

    }
}
