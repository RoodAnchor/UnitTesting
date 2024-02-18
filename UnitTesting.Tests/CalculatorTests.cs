using NUnit.Framework;

namespace UnitTesting.Tests
{
    /// <summary>
    /// Юнит тесты калькулятора
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator = new Calculator();
        
        /// <summary>
        /// Тест на корректность сложения
        /// </summary>
        [Test]
        public void AdditionShouldReturnCorrectValue() =>
            Assert.That(_calculator.Addition(2, 3) == 5);

        /// <summary>
        /// Тест на корректность вычитания
        /// </summary>
        [Test]
        public void SubtractionShouldReturnCorrectValue() =>
            Assert.That(_calculator.Subtraction(5, 3) == 2);

        /// <summary>
        /// Тест на корректность умножения
        /// </summary>
        [Test]
        public void MultiplicationShouldReturnCorrectValue() =>
            Assert.That(_calculator.Multiplication(2, 3) == 6);

        /// <summary>
        /// Тест на корректность деления
        /// </summary>
        [Test]
        public void DivisionShouldReturnCorrectValue() =>
            Assert.That(_calculator.Division(6, 3) == 2);

        /// <summary>
        /// Тест на исключение деления на ноль.
        /// </summary>
        [Test]
        public void DivisionShouldThrowDivisionByZeroException() =>
            Assert.Throws(typeof(DivideByZeroException), () => _calculator.Division(2, 0));
    }
}