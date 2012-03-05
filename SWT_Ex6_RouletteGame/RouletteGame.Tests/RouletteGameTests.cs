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
        UIStub uisStub;

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            rsRoulette = new RouletteStub();
            bsBet = new BetStub();
            uisStub = new UIStub();
            rgTestObj = new RouletteGame(rsRoulette, uisStub);
        }
        [TearDown]
        public void teardown()
        {
            rgTestObj = null;
            uisStub = null;
            bsBet = null;
            rsRoulette = null;
        }

        // Tests
        [Test]
        public void PlaceBet_PlacedBetWhileRoundIsOpen_IsAccepted()
        {
            rgTestObj.OpenBets();
            Assert.DoesNotThrow(delegate { rgTestObj.PlaceBet(bsBet); }); 
        }
        [Test]
        public void PlaceBet_PlacedBetWhileRoundIsClosed_ThrowsRouletteGameException()
        {
            Assert.Throws<RouletteGameException>(delegate { rgTestObj.PlaceBet(bsBet); }); 
        }
        [Test]
        public void CloseBets_PlacesBetAfterClosed_ThrowsRouletteGameException()
        {
            rgTestObj.OpenBets();
            rgTestObj.CloseBets();
            Assert.Throws<RouletteGameException>(delegate { rgTestObj.PlaceBet(bsBet); }); 
        }
        [Test]
        public void PlaceBet_PlacesBet_BetGetsAdded()
        {
            // Mock
        }
        [Test]
        public void SpinRoulette_SpinsRoulette_RouletteGetsSpinned()
        {
            // Mock
        }
        [Test]
        public void PayUp_HaveAWinningBet_GetsPrintedOut()
        {
            rgTestObj.OpenBets();
            rgTestObj.PlaceBet(bsBet);
            rgTestObj.CloseBets();
            rgTestObj.PayUp();
            StringAssert.Contains(bsBet.PlayerName, uisStub.String);
        }
        [Test]
        public void SpinRoulette_SpinWithOpenBets_ThrowsException()
        {
            rgTestObj.OpenBets();
            Assert.Throws<RouletteGameException>(delegate { rgTestObj.SpinRoulette(); });
        }
    }
}
