// using System;
using Xunit;
using sudoku;
using lib;

namespace test
{
    public class TestCell
    {

        [Fact]
        public void testBasicConst()
        {
            
            AbstractCell c = new SudokuCell(1, 2);

            Assert.Equal("(1, 2, ' ')", c.ToString());
        }

        [Fact]
        public void testFullConst()
        {
            AbstractCell c = new SudokuCell(1, 2, 'a');

            Assert.Equal("(1, 2, 'a')", c.ToString());
        }

        [Fact]
        public void testBasicPairConst()
        {
            Pair<int> p = new Pair<int>(1, 2);
            AbstractCell c = new SudokuCell(p);

            Assert.Equal("(1, 2, ' ')", c.ToString());
        }

        [Fact]
        public void testFullPairConst()
        {
            Pair<int> p = new Pair<int>(1, 2);
            AbstractCell c = new SudokuCell(p, 'a');

            Assert.Equal("(1, 2, 'a')", c.ToString());
        }

        [Fact]
        public void testCopyConst()
        {
            Pair<int> p = new Pair<int>(1, 2);
            AbstractCell c1 = new SudokuCell(p, 'a');

            AbstractCell c2 = new SudokuCell(c1);

            Assert.Equal("(1, 2, 'a')", c1.ToString());
            Assert.Equal("(1, 2, 'a')", c2.ToString());
        }
    }
}
