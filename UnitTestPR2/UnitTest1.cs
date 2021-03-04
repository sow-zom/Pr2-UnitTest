using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Pr2.rZF;

namespace UnitTestPR2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0.66666666666666666, POD(4, 6), "Ой шось не файно");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(10, DOD(4, 6), "Ой шось не файно");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(24, POM(4, 6), "Ой шось не файно");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(-2, VID(4, 6), "Ой шось не файно");
        }

    }
}
