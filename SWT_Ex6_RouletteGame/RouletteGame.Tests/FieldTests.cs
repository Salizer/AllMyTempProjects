using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RouletteGame.Tests
{
    [TestFixture]
    class FieldTests
    {
        // Members
        private Field fTestObj;
        private uint uiNumber;
        private uint uiColor;
        private bool bEven;

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            uiNumber = 2;
            uiColor = Field.Black;
            bEven = true;
            fTestObj = new Field(uiNumber, uiColor);
        }
        [TearDown]
        public void teardown()
        {
            fTestObj = null;   
        }

        // Tests
        [Test]
        public void Color_SetsColorGreen_IsNowGreen()
        {
            
        }
        [Test]
        public void Color_SetsColorBlack_IsNowBlack()
        {
            
        }
        [Test]
        public void Color_SetsColorRed_IsNowRed()
        {
            
        }
        [Test]
        public void Number_ValidNumber_IsSaved()
        {
            
        }
        [Test]
        public void Number_InValidNumber_ThrowsException()
        {
            
        }
        [Test]
        public void Even_EvenNumber_ReturnsTrue()
        {
            
        }
        [Test]
        public void Even_NotEvenNumber_ReturnsFalse()
        {
            
        }
    }
}
