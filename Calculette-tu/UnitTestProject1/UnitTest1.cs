using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatriceTU;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdditioner()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "+");
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void TestMethodSoustraire()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "-");
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void TestMethodDiviser()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "/");
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void TestMethodMultiplier()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "*");
            Assert.AreEqual(result, 25);
        }
    }
}