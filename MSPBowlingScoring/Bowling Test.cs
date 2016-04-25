using System;
using MSPBowlingScoring;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class BowlingTest
{
    [TestMethod]
    public void bowlingTest()
    {
        Game g = new Game();
        g.roll();
    }
}
