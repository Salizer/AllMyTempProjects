using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RouletteGame.Tests
{
    [TestFixture]
    class RouletteGameTests
    {
        // Members
        RouletteGame rgTestObj;
        RouletteStub rsRoulette;
        BetStub bsBet;

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            rsRoulette = new RouletteStub();
            bsBet = new BetStub();
            rgTestObj = new RouletteGame(rsRoulette);
        }
        [TearDown]
        public void teardown()
        {
            rgTestObj = null;
            bsBet = null;
            rsRoulette = null;
        }
    }
}
