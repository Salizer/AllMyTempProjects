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

        // Setup and teardown
        [SetUp]
        public void setup()
        {
            uiNumber = 2;
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
            fTestObj = new Field(uiNumber, Field.Green);
            Assert.AreEqual(Field.Green, fTestObj.Color, "Color not saved.");
        }
        [Test]
        public void Color_SetsColorBlack_IsNowBlack()
        {
            fTestObj = new Field(uiNumber, Field.Black);
            Assert.AreEqual(Field.Black, fTestObj.Color, "Color not saved.");
        }
        [Test]
        public void Color_SetsColorRed_IsNowRed()
        {
            fTestObj = new Field(uiNumber, Field.Red);
            Assert.AreEqual(Field.Red, fTestObj.Color, "Color not saved.");
        }
        [Test]
        public void Color_SetsInvalidColor_ThrowsFieldException()
        {
            Assert.Throws<FieldException>(delegate { fTestObj = new Field(uiNumber, 102012); });
        }
        [Test]
        public void Number_ValidNumber_IsSaved()
        {
            fTestObj = new Field(0, uiColor);
            Assert.AreEqual(0, fTestObj.Number);
            fTestObj = new Field(5, uiColor);
            Assert.AreEqual(5, fTestObj.Number);
            fTestObj = new Field(36, uiColor);
            Assert.AreEqual(36, fTestObj.Number);
        }
        [Test]
        public void Number_SetsInvalidNumber_ThrowsException()
        {
            Assert.Throws<FieldException>(delegate { fTestObj = new Field(37, Field.Black); });
        }
        [Test]
        public void Even_EvenNumber_ReturnsTrue()
        {
            fTestObj = new Field(2, uiColor);
            Assert.IsTrue(fTestObj.Even);
        }
        [Test]
        public void Even_NotEvenNumber_ReturnsFalse()
        {
            fTestObj = new Field(3, uiColor);
            Assert.IsFalse(fTestObj.Even);
        }
        [Test]
        public void ToString_FieldIsRed_ContainsTheColorInString()
        {
            fTestObj = new Field(uiNumber, Field.Red);
            StringAssert.Contains("red", fTestObj.ToString());
        }
        [Test]
        public void ToString_FieldIsBlack_ContainsTheColorInString()
        {
            fTestObj = new Field(uiNumber, Field.Black);
            StringAssert.Contains("black", fTestObj.ToString());
        }
        [Test]
        public void ToString_FieldIsGreen_ContainsTheColorInString()
        {
            fTestObj = new Field(uiNumber, Field.Green);
            StringAssert.Contains("green", fTestObj.ToString());
        }
    }
}
