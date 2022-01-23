using Xunit;

namespace CpGymCsharp.judges.codeforces
{
    public class DistorsionAlfabeticaCircularUnitTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("2", DistorsionAlfabeticaCircular.Solve("abcdefghijklmnopqrstuvwxxx"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("23", DistorsionAlfabeticaCircular.Solve("elcincogproducecovidesreal"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("22", DistorsionAlfabeticaCircular.Solve("berthinaproboelexamendevih"));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("imposible", DistorsionAlfabeticaCircular.Solve("felicitaciones"));
        }
    }
}
