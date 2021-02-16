using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10, -5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,5,10)]
        [InlineData(5,5, 25)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            var actual = test2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,5,4)]
        [InlineData(15,3,5)]
        public void Divide(int one, int two, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            var actual = test3.Divide(one, two);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
