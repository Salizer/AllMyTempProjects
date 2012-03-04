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

        // Setup and teardown
        [SetUp]
        void setup()
        {
            fbTestObj = new FieldBet(sUserName, uiAmount, uiFieldNumber); 
        }

        [TearDown]
        void teardown()
        {
            fbTestObj = null; 
        }

        // Tests
        [Test]
        void WonAmount_GotWinningNumber_GetMoney()
        {
            
        }
    }
}
