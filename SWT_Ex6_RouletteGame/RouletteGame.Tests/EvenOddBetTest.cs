using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RouletteGame.Tests
{
    [TestFixture]
    public class EvenOddBetTest
    {
        // Members
        private string _sEvenOdd;
        private uint _uiAmount;
        private uint _uiWonAmount;
        private EvenOddBet _eobTestObj;
        private bool _even;
        private FieldStub fsFieldStub;

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            _sEvenOdd = "Odd";
            _uiAmount = 100;
            _uiWonAmount = 200;
            _eobTestObj = new EvenOddBet(_sEvenOdd,_uiAmount,_even);
            fsFieldStub = new FieldStub();
        }

        [TearDown]
        public void teardown()
        {
            _eobTestObj = null;
            fsFieldStub = null;
        }

        [Test]
        public void WonAmount_WinningOnEvenNumber_GetMoney()
        {
            _eobTestObj = new EvenOddBet(_sEvenOdd, _uiAmount, true);
            fsFieldStub.Even = true;
            Assert.Greater(_eobTestObj.WonAmount(fsFieldStub) ,0);
        }

        [Test]
        public void WonAmount_WinningOnOddNumber_GetMoney()
        {
            _eobTestObj = new EvenOddBet(_sEvenOdd, _uiAmount, false);
            fsFieldStub.Even = false;
            Assert.Greater(_eobTestObj.WonAmount(fsFieldStub), 0);
        }
        [Test]
        public void EvenOdd_OddString_WriteOdd()
        {
            StringAssert.Contains(_uiAmount.ToString(), _eobTestObj.ToString());
            // Mangler lige string-test
        }
    }
}