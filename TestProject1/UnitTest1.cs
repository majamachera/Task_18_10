
using NUnit.Framework;
using System;
using Task_18_10;

namespace TestProject1
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnFalseForWrongPattern()
        {
            string fromUserText = "9mg";
            bool result = Program.CorrectPattern(fromUserText);
            Assert.IsFalse(result);
        }
       

        [Test]
        public void ShouldReturnFalseForWrongUnitVariables()
        {
            string unitFrom = "qwert";
            string unitTo = "uiop";
            bool result = Program.UnitVariables(unitFrom, unitTo);
            Assert.IsFalse(result);
        }
        
        [Test]
        public void ShouldReturnExistingUnitTo()
        {
            string unitTo = "g";
            string line= "5g, g";
            Program.LoadVariables(line, out int value, out string unitfrom, out string unitto);
            Assert.AreEqual(unitTo, unitto);
            
        }
        [Test]
        public void ShouldReturnExistingUnitFrom()
        {
            string unitFrom = "g";
            string line = "5g, g";
            Program.LoadVariables(line, out int value, out string unitfrom, out string unitto);
            Assert.AreEqual(unitFrom, unitfrom);
        }
        [Test]
        public void ShouldReturnExistingValue()
        {
            string line = "5g, g";
            int Value = 5;
            Program.LoadVariables(line, out int value, out string unitfrom, out string unitto);
            Assert.AreEqual(value, Value);
        }
       
    }
}