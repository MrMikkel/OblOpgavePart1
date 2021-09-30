using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_CsharpAndUnittests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Knud", 1234, 12);
            Assert.AreEqual(1,footballPlayer.Id);
            Assert.AreEqual("Knud", footballPlayer.Name);
            Assert.AreEqual(1234, footballPlayer.Price);
            Assert.AreEqual(12, footballPlayer.ShirtNumber);
            Assert.ThrowsException<ArgumentException>(() => new FootballPlayer(0, "Knud", 1234, 12));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new FootballPlayer(1, "Knu", 1234, 12));
            Assert.ThrowsException<ArgumentNullException>(() => new FootballPlayer(1, null, 1234, 12));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new FootballPlayer(1, "Knud", -32, 12));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new FootballPlayer(1, "Knud", 1234, 132));
        }
        [TestMethod]
        public void IdTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Knud", 1234, 12);
            Assert.AreEqual(1, footballPlayer.Id);
            footballPlayer.Id = 2;
            Assert.AreEqual(2,footballPlayer.Id);
            Assert.ThrowsException<ArgumentException>(() => footballPlayer.Id = 0);
        }
        [TestMethod]
        public void NameTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Knud", 1234, 12);
            Assert.AreEqual("Knud", footballPlayer.Name);
            footballPlayer.Name = "Hejsa";
            Assert.AreEqual("Hejsa", footballPlayer.Name);
            Assert.ThrowsException<ArgumentNullException>(() => footballPlayer.Name = null);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.Name = "Hej");
        }

        [TestMethod]
        public void PriceTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Knud", 1234, 12);
            Assert.AreEqual(1234, footballPlayer.Price);
            footballPlayer.Price = 4321;
            Assert.AreEqual(4321, footballPlayer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.Price = -1);
        }

        [TestMethod]
        public void ShirtNumberTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Knud", 1234, 12);
            Assert.AreEqual(12, footballPlayer.ShirtNumber);
            footballPlayer.ShirtNumber = 67;
            Assert.AreEqual(67, footballPlayer.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.ShirtNumber = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.ShirtNumber = 101);
        }
    }
}
