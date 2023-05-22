using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 1, 19, 30)]
        [InlineData(12, 22, 87, 121)]
        [InlineData(4, -5, 2, 1)]
        [InlineData(32, 36, 27, 95)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var sum = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = sum.Add(num1, num2, num3);

            //Assert
             Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(47, 32, 15)]//Add test data <-------
        [InlineData(70, 37, 33)]
        [InlineData(4, 7, -3)]
        [InlineData(5, -14, 19)]
        [InlineData(0, 420, -420)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var sub = new Calculator();

            //Act
            var actual = sub.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 7, 84)]//Add test data <-------
        [InlineData(13, 7, 91)]
        [InlineData(91, 5, 455)]
        [InlineData(84, 5, 420)]
        [InlineData(-14, 0, 0)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var mult = new Calculator();

            //Act
            var actual = mult.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(63, 9, 7)]//Add test data <-------
        [InlineData(0, 87, 0)]
        [InlineData(6, 2, 3)]
        [InlineData(49, 7, 7)]
        [InlineData(32, 2, 16)]

        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divi = new Calculator();

            //Act
            var actual = divi.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
