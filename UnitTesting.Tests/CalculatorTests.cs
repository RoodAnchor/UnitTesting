using NUnit.Framework;

namespace UnitTesting.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator = new Calculator();

        [Test]
        public void AdditionShouldReturnCorrectValue() =>
            Assert.That(_calculator.Addition(2, 3) == 5);

        [Test]
        public void SubtractionShouldReturnCorrectValue() =>
            Assert.That(_calculator.Subtraction(5, 3) == 2);

        [Test]
        public void MultiplicationShouldReturnCorrectValue() =>
            Assert.That(_calculator.Multiplication(2, 3) == 6);

        [Test]
        public void DivisionShouldReturnCorrectValue() =>
            Assert.That(_calculator.Division(6, 3) == 2);

        [Test]
        public void DivisionShouldThrowDivisionByZeroException() =>
            Assert.Throws(typeof(DivideByZeroException), () => _calculator.Division(2, 0));
    }
}