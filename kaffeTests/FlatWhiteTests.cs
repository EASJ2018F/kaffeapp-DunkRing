using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;

namespace kaffeTests
{
    [TestClass]
    public class FlatWhiteTests
    {
        [TestMethod]
        public void TestPrisIFlatWhite()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            int pris = flatWhite.Pris();

            //assert
            Assert.AreEqual(45, pris);

        }

        [TestMethod]
        public void TestFlatWhiteStyrke()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            string styrke = flatWhite.Styrke();

            //assert
            Assert.AreEqual("Mild", styrke);

        }

        [TestMethod]
        public void TestFlatWhiteMlMælk()
        {
            //Arrange
            var flatWhite = new FlatWhite();

            //Act
            int MlMælk = flatWhite.MlMælk();

            //assert
            Assert.AreEqual(160, MlMælk);

        }
    }
}
