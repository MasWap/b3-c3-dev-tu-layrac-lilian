using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatriceTU;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        //Test permettant de vérifier si le calcule de l'addition fonctionne
        [TestMethod]
        public void TestMethodAdditioner()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "+");
            Assert.AreEqual(result, 10);
        }

        //Test permettant de vérifier si le calcule de la soustraction fonctionne
        [TestMethod]
        public void TestMethodSoustraire()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "-");
            Assert.AreEqual(result, 0);
        }

        //Test permettant de vérifier si le calcule de division fonctionne
        [TestMethod]
        public void TestMethodDiviser()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "/");
            Assert.AreEqual(result, 1);
        }

        //Test permettant de vérifier si le calcule de multiplication fonctionne
        [TestMethod]
        public void TestMethodMultiplier()
        {
            Calcules c = new Calcules();
            double result = c.Calculer(5, 5, "*");
            Assert.AreEqual(result, 25);
        }
    }
}