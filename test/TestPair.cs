using Xunit;
using lib;

namespace test
{
    public class TestPair
    {
        [Fact]
        public void testPair()
        {
            Pair<int> p = new Pair<int>(4, 5);

            Assert.Equal(4, p.first);
            Assert.Equal(5, p.second);
        }

        
    }
}
