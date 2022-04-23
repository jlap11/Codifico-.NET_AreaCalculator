using AreaCalculator;
using Xunit;

namespace AreaCalculator.Test
{
    public class RectangleTest
    {

        Rectangle objRectangle = new Rectangle();

        /// <summary>
        /// This stage is when the params are 0.
        /// </summary>
        [Fact]
        public void Zero_Values()
        {
            //Arrange
            objRectangle.Base = 0;
            objRectangle.Height = 0;
            var response = objRectangle.CalculateArea();

            //Assert
            Assert.Equal(0, response);
        }

        /// <summary>
        /// This stage is when the params are Decimals.
        /// </summary>
        [Fact]
        public void Decimal_Values()
        {
            //Arrange
            objRectangle.Base = 7.9;
            objRectangle.Height = 54.3;
            var response = objRectangle.CalculateArea();

            //Assert
            Assert.Equal(428.96999999999997, response);
        }

    }
}