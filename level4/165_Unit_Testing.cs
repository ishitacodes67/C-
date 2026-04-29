// Unit Testing using NUnit 
using System;
using NUnit.Framework;
namespace UnitTesting
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}
