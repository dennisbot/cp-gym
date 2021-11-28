using Xunit;

namespace CpGymCsharp.uva
{
    public class ReverseAndAddUnitTest
    {
        [Fact]
        public void Test195()
        {
            Assert.Equal("4 9339", ReverseAndAdd.Solve(195));
        }

        [Fact]
        public void Test265()
        {
            Assert.Equal("5 45254", ReverseAndAdd.Solve(265));
        }

        [Fact]
        public void Test750()
        {
            Assert.Equal("3 6666", ReverseAndAdd.Solve(750));
        }
    }
}
