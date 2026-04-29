// Mocking using Moq
using System;
using Moq;
namespace Mocking
{
    public interface ICalculator
    {
        int Add(int a, int b);
    }

    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class CalculatorTests
    {
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(m => m.Add(5, 3)).Returns(8);

            // Act
            int result = mockCalculator.Object.Add(5, 3);

            // Assert
            if (result != 8)
            {
                throw new Exception("Test failed: Expected 8 but got " + result);
            }
        }
    }
}
