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
        private string sUserName;
        private uint uiAmount;
        private uint uiFieldNumber;
        private FieldStub fsFieldStub;

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            sUserName = "user1";
            uiAmount = 1000;
            uiFieldNumber = 1;
            fbTestObj = new FieldBet(sUserName, uiAmount, uiFieldNumber);
            fsFieldStub = new FieldStub();
        }

        [TearDown]
        public void teardown()
        {
            fbTestObj = null;
            fsFieldStub = null;
        }

        // Tests
        [Test]
        public void WonAmount_GotWinningNumber_GetMoney()
        {
            fsFieldStub.Number = uiFieldNumber;
            Assert.Greater(fbTestObj.WonAmount(fsFieldStub), 0); 
        }
        [Test]
        public void WonAmount_GotWinningNumber_GetsRightAmountOfMoney()
        {
            fsFieldStub.Number = uiFieldNumber;
            Assert.AreEqual(uiAmount * 36, fbTestObj.WonAmount(fsFieldStub)); 
        }
        [Test]
        public void WonAmount_DidntWin_GetZeroMoney()
        {
            fsFieldStub.Number = 2;
            Assert.AreEqual(0, fbTestObj.WonAmount(fsFieldStub)); 
        }
        [Test]
        public void ToString_GettingString_GetsTheCorrectString()
        {
            StringAssert.Contains(uiAmount.ToString(), fbTestObj.ToString());
            StringAssert.Contains(uiFieldNumber.ToString(), fbTestObj.ToString());
        }
    }
}
