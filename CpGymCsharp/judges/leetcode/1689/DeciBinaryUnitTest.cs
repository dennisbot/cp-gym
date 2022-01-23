using Xunit;

namespace CpGymCsharp.judges.leetcode
{
    public class DeciBinaryUnitTest
    {
        [Fact]
        public void Test47()
        {
            Assert.Equal(7, DeciBinary.MinPartitions("47"));
        }

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
