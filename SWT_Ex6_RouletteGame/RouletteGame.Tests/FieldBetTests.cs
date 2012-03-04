using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RouletteGame.Tests
{
    [TestFixture]
    public class FieldBetTests
    {
        // Members
        private FieldBet fbTestObj;
        private string sUserName = "user1";
        private uint uiAmount = 1000;
        private uint uiFieldNumber = 1;
        private FieldStub fsFieldStub;

        // Setup and teardown
        [SetUp]
        void setup()
        {
            fbTestObj = new FieldBet(sUserName, uiAmount, uiFieldNumber);
            fsFieldStub = new FieldStub();
        }

        [TearDown]
        void teardown()
        {
            fbTestObj = null;
            fsFieldStub = null;
        }

        // Tests
        [Test]
        void WonAmount_GotWinningNumber_GetMoney()
        {
            fsFieldStub.Number = uiFieldNumber;
            Assert.Greater(fbTestObj.WonAmount(fsFieldStub), 0); 
        }
        [Test]
        void WonAmount_GotWinningNumber_GetsRightAmountOfMoney()
        {
            fsFieldStub.Number = uiFieldNumber;
            Assert.AreEqual(uiAmount * 36, fbTestObj.WonAmount(fsFieldStub)); 
        }
        [Test]
        void WonAmount_DidntWin_GetZeroMoney()
        {
            fsFieldStub.Number = 2;
            Assert.AreEqual(0, fbTestObj.WonAmount(fsFieldStub)); 
        }
    }
}
