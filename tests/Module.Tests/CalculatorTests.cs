using System;
using NUnit.Framework;
using Module.Core;

namespace Module.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void Add_ReturnsCorrectResult(double a, double b, double expected)
        {
            Assert.AreEqual(expected, _calculator.Add(a, b));
        }

        [TestCase(5, 3, 2)]
        [TestCase(0, 5, -5)]
        [TestCase(-2, -3, 1)]
        public void Subtract_ReturnsCorrectResult(double a, double b, double expected)
        {
            Assert.AreEqual(expected, _calculator.Subtract(a, b));
        }

        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(0, 5, 0)]
        public void Multiply_ReturnsCorrectResult(double a, double b, double expected)
        {
            Assert.AreEqual(expected, _calculator.Multiply(a, b));
        }

        [TestCase(6, 2, 3)]
        [TestCase(-6, 2, -3)]
        [TestCase(5, 2, 2.5)]
        public void Divide_ReturnsCorrectResult(double a, double b, double expected)
        {
            Assert.AreEqual(expected, _calculator.Divide(a, b));
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        }
    }
}
