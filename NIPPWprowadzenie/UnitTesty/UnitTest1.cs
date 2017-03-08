using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteka;

namespace UnitTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestCleanup]
        public void Teardown()
        {

        }

        [TestMethod]
        public void Test_IfWiekszyNiz05()
        {
            // Arrange
            PrzykladowaKlasa testowyObiekt = new PrzykladowaKlasa(5);
            string oczekiwanyWynik = "Testowana zmienna byla wieksza niz 0.5";
            // Act
            string wynik = testowyObiekt.PrzykladIf(2);

            // Assert
            Assert.AreEqual(oczekiwanyWynik, wynik);
        }

        [TestMethod]
        public void Test_IfMniejszyNiz05()
        {
            // Arrange
            PrzykladowaKlasa testowyObiekt = new PrzykladowaKlasa(0);
            string oczekiwanyWynik = "Testowana zmienna byla mniejsza niz 0.5";
            // Act
            string wynik = testowyObiekt.PrzykladIf(0);

            // Assert
            Assert.AreEqual(oczekiwanyWynik, wynik);
        }
    }
}
