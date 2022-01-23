using Xunit;

namespace CpGymCsharp.judges.codeforces
{
    public class SpidermanUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Spiderman.PossibleNewLove("Michelle Jones"));
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Spiderman.PossibleNewLove("Mary Jane"));
        }

        [Fact]
        public void Test3()
        {
            Assert.False(Spiderman.PossibleNewLove("Gwen Stacy"));
        }

        [Fact]
        public void Test4()
        {
            Assert.False(Spiderman.PossibleNewLove("Cindy Moon"));
        }
    }
}
