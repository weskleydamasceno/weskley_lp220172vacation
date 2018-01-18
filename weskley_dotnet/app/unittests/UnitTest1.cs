using System;
using Xunit;
using bll;

namespace unittests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSoma()
        {
            Class1 c = new Class1();
            int x = 10;
            int y = 10;
            int atual = c.Soma(x,y);
            Assert.Equal(20, atual);
        }
    }
}
