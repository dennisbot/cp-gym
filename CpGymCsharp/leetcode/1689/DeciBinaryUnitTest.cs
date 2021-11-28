using Xunit;

namespace CpGymCsharp.leetcode
{
    public class DeciBinaryUnitTest
    {
        [Fact]
        public void Test32()
        {
            Assert.Equal(3, DeciBinary.MinPartitions("32"));
        }

        [Fact]
        public void Test82734()
        {
            Assert.Equal(8, DeciBinary.MinPartitions("82734"));
        }

        [Fact]
        public void Test2734620()
        {
            Assert.Equal(9, DeciBinary.MinPartitions("27346209830709182346"));
        }
    }
}
