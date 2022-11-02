using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetMaximumTest1()
        {
            var maxdigit = Logic.GetMaximum(405);
            Assert.AreEqual(5, maxdigit);
        }
        [TestMethod()]
        public void GetMaximumTest2()
        {
            var maxdigit = Logic.GetMaximum(981);
            Assert.AreEqual(9, maxdigit);
        }
        [TestMethod()]
        public void GetMaximumTest3()
        {
            var maxdigit = Logic.GetMaximum(162);
            Assert.AreEqual(6, maxdigit);
        }
        [TestMethod()]
        public void GetMaximumTest4()
        {
            var maxdigit = Logic.GetMaximum(666);
            Assert.AreEqual(6, maxdigit);
        }
        [TestMethod()]
        public void GetMaximumTest5()
        {
            var maxdigit = Logic.GetMaximum(606);
            Assert.AreEqual(6, maxdigit);
        }
    }
}