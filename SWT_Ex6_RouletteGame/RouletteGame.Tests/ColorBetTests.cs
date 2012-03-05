using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RouletteGame.Tests
{
    [TestFixture]
    class ColorBetTests
    {
        // Members
        private string _sName;
        private uint _uiAmount;
        private uint _uiColor;
        private ColorBet _cbTestObj;
        private FieldStub _fsFieldStub;

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            _sName = "PlayerX";
            _uiAmount = 100;
            _uiColor = 0;
            _cbTestObj = new ColorBet(_sName,_uiAmount, _uiColor);
            _fsFieldStub = new FieldStub();
        }

        [TearDown]
        public void teardown()
        {
            _cbTestObj = null;
            _fsFieldStub = null;
        }

        [Test]
        public void WonAmount_OnBlack_GetMoney()
        {
            _cbTestObj = new ColorBet(_sName, _uiAmount, Field.Black);
            _fsFieldStub.Color = Field.Black;
            Assert.Greater(_cbTestObj.WonAmount(_fsFieldStub),0);
        }
    
        [Test]
        public void WonAmount_OnRed_GetMoney()
        {
            _cbTestObj = new ColorBet(_sName, _uiAmount, Field.Red);
            _fsFieldStub.Color = Field.Red;
            Assert.Greater(_cbTestObj.WonAmount(_fsFieldStub), 0);
        }
        
        [Test]
        public void WonAmount_OnGreen_GetMoney()
        {
            _cbTestObj = new ColorBet(_sName, _uiAmount, Field.Green);
            _fsFieldStub.Color = Field.Green;
            Assert.Greater(_cbTestObj.WonAmount(_fsFieldStub), 0);
        }
    }
}
