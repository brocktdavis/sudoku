using System;

namespace sudoku
{
    public class Cell
    {
        private char _v { get; } = ' ';

        public Cell() { }
        public Cell(char v) => _v = v;

        public override String ToString() {
            return _v.ToString();
        }

    }
}
