using NUnit.Framework;
using System;
using UnitLibrary;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ShouldReturnCorrectUnitGramForString()
        {
            string text = "g";
            Unit gram = new Gram();
            Unit result = UnitFactory.FromString(text);
            Assert.AreEqual(gram.Value, result.Value);
        }
        [Test]
        public void ShouldReturnCorrectUnitForString()
        {
            string text = "mg"; 
            Miligram miligram = new Miligram();
            Unit result = UnitFactory.FromString(text);
            Assert.AreEqual(miligram.Value, result.Value);
        }
        [Test]
        public void ShouldReturnTheSameForGramToGram()
        {
            Unit from = new Gram();
            Unit to = new Gram();
            double value = 4;
            decimal result = Converter.Convert(from, to, value);
            Assert.AreEqual(value, result);
        }
        [Test]
        public void ShouldReturnCorrectResultForMiliGramToGram()
        {
            Unit from = new Miligram();
            Unit to = new Gram();
            double value = 7;
            double result1 = 0.007;
            decimal result = Converter.Convert(from, to, value);
            Assert.AreEqual(result1, result);
        }
        [Test]
        public void ShouldReturnCorrectResultForPoundToGram()
        {
            Unit from = new Pound();
            Unit to = new Gram();
            double value = 8;
            double result1 = 3628.73896;
            decimal result = Converter.Convert(from, to, value);
            Assert.AreEqual(result1, result);
        }
        [Test]
        public void ShouldReturnCorrectResultForOunceToGram()
        {
            Unit from = new Ounce();
            Unit to = new Gram();
            double value = 3;
            double result1 = 85.048569375;
            decimal result = Converter.Convert(from, to, value);
            Assert.AreEqual(result1, result);
        }

    }
}