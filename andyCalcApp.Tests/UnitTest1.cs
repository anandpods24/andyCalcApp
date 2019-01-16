using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace andyCalcApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        andyCalc obj = new andyCalc();
        [TestMethod]
        public void addtest()
        {
            Assert.AreEqual(15, obj.add(10, 5));
        }
        [TestMethod]
        public void subtest()
        {
            Assert.AreEqual(5, obj.sub(10, 5));
        }
        [TestMethod]
        public void multtest()
        {
            Assert.AreEqual(50, obj.mult(10, 5));
        }
    }
}
