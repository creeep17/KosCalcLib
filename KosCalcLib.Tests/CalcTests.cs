using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KosCalcLib.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_10n20_30returned()
        {
            // arrange
            int x = 20;
            int y = 10;
            int z = 25;
            int exp = 55;

            //act
            Calc c = new Calc();
            int actual = c.Sum(x, y, z);

            // assert
            Assert.AreEqual(exp, actual);
        }
    }
}
