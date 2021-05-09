// using System;
using Xunit;
using sudoku;

namespace test
{
    public class TestCell
    {
        [Fact]
        public void Deafult()
        {
            sudoku.Cell c = new Cell();

            Assert.Equal(" ", c.ToString());
        }
    }
}
