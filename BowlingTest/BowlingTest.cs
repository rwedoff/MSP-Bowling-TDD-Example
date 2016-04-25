using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSPBowlingScoring;
namespace BowlingTest
{
    [TestClass]
    public class BowlingTest
    {
        private Game g;

        [TestInitialize]
        public void setUp()
        {
            g = new Game();
        }
        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.roll(pins);
            }
        }
        [TestMethod]
        public void testGutterGame()
        {
            rollMany(20, 0);
            Assert.AreEqual(0, g.getScore());   
        }
        [TestMethod]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, g.getScore());
        }

       
        
        [TestMethod]
        public void testOneSpare()
        {
            rollSpare();
            g.roll(3);
            rollMany(17, 0);
            Assert.AreEqual(16, g.getScore());
        }

        private void rollSpare()
        {
            g.roll(5);
            g.roll(5);
        }

        [TestMethod]
        public void testOneStrike() 
        {
            rollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(16, 0);
            Assert.AreEqual(24, g.getScore());
        }

        [TestMethod]
        public void testPerfectGame()
        {
            rollMany(12,10);
            Assert.AreEqual(300, g.getScore());
        }

        private void rollStrike()
        {
            g.roll(10);
        }
    }
}
