using System;
using Xunit;

namespace HomeWork8.Tests
{
    public class CalculatorTests
    {
        [Fact]
         public void GetSum_2_plus_3_eq_5()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.GetSum(2, 3);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void GetMultiply_2_To_3_Eq_6()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.GetMultiply(2, 3);

            //Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void GetDivide_6_To_2_Eq_3()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.GetDivide(6, 2);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void GetDivideByZero()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.GetDivide(1, 0);
           //Assert
            Assert.Equal(double.PositiveInfinity, result);
          
        }
    }
}
