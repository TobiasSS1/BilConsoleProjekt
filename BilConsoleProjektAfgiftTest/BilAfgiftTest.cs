using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilConsoleProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilConsoleProjekt.AfgiftTest
{
    [TestClass()]
    public class BilAfgiftTest
    {
        [TestMethod()]
        public void RegistreringsAfgift2015High()
        {
            //arrange
            DieselBil MinBil = new DieselBil(80500, 2015, "Volvo", "AJ 5094", 10, 3);
            
            //act
            
            //assert
            Assert.AreEqual(84525, MinBil.RegistreringsAfgift());
            
        }

        [TestMethod()]
        public void RegistreringsAfgift2014()
        {
            DieselBil MinBil = new DieselBil(80499, 2014, "Volvo", "AJ 5094", 10, 3);
            Assert.AreEqual(87741, MinBil.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgift2016()
        {
            DieselBil MinBil = new DieselBil(40499, 2014, "Volvo", "AJ 5094", 10, 3);
            Assert.AreEqual(42523, MinBil.RegistreringsAfgift());
        }

        [TestMethod()]
        public void RegistreringsAfgift2016high()
        {
            DieselBil MinBil = new DieselBil(40009, 2016, "Volvo", "AJ 5094", 10, 3);
            Assert.AreEqual(10257, MinBil.RegistreringsAfgift());
        }

        [TestMethod()]
        public void HalvårligEjerafgift()
        {
            //Arrange
            DieselBil MinBil = new DieselBil(80600, 2014, "Volvo", "AJ 5094", 10, 3);
            int expectedAfgift = 2000;
            //Act

            int AktuelAfgift = MinBil.HalvÅrligEjerAfgift();

            //Assert
            Assert.AreEqual(expectedAfgift, AktuelAfgift);
        }

        [TestMethod()]
        public void HalvårligEjerafgiftBenzin()
        {
            //Arrange
            BenzingBil MinBil = new BenzingBil(80600, 2014, "Volvo", "AJ 5094", 10, 3);
            int expectedAfgift = 1200;
            //Act

            int AktuelAfgift = MinBil.HalvÅrligEjerAfgift();

            //Assert
            Assert.AreEqual(expectedAfgift, AktuelAfgift);
        }

        [TestMethod()]
        public void HalvårligEjerafgiftEl()
        {
            //Arrange
            ElBil MinBil = new ElBil(80600, 2014, "Volvo", "AJ 5094", 10, 3);
            int expectedAfgift = 0;
            //Act

            int AktuelAfgift = MinBil.HalvÅrligEjerAfgift();

            //Assert
            Assert.AreEqual(expectedAfgift, AktuelAfgift);
        }

        [TestMethod()]
        public void RækkevideDiesel()
        {
            //Arrange
            DieselBil MinBil = new DieselBil(80600, 2014, "Volvo", "AJ 5094", 10, 3);
            int expectedRække = 30;
            //Act

            int AktuelRække = MinBil.RækkeVidde();

            //Assert
            Assert.AreEqual(expectedRække, AktuelRække);
        }

        [TestMethod()]
        public void RækkevideBenzin()
        {
            //Arrange
            BenzingBil MinBil = new BenzingBil(80600, 2014, "Volvo", "AJ 5094", 10, 3);
            int expectedRække = 30;

            //Act
            int AktuelRække = MinBil.RækkeVidde();

            //Assert
            Assert.AreEqual(expectedRække, AktuelRække);
        }
    }
}