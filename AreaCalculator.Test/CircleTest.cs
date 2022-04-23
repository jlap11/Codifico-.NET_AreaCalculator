using AreaCalculator;
using Xunit;


namespace AreaCalculator.Test
{
    public class CircleTest
    {
        Circle objCircle = new Circle();

        /// <summary>
        /// This stage is when the params are 0.
        /// </summary>
        [Fact]
        public void Zero_Value()
        {
            //Arrange
            objCircle.Radio = 0;            
            var response = objCircle.CalculateArea();

            //Assert
            Assert.Equal(0, response);
        }

        /// <summary>
        /// This stage is when the params are Decimals.
        /// </summary>
        [Fact]
        public void Decimal_Value()
        {
            //Arrange
            objCircle.Radio = 7.9;
            var response = objCircle.CalculateArea();

            //Assert
            Assert.Equal(196.06101500000003, response);
        }
    }
}
