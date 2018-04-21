using System;
using NUnit.Framework;

namespace AdvancedMath1963.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(5, 120)]
        [TestCase(10, 3628800)]
        public void Factorial_WhenCalled_ReturnsCorrectValue(int param, int expectedResult)
        {
            //Act
            var result = Calculator.Factorial(param);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
