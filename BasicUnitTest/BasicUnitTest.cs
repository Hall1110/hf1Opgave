using Basic;

namespace BasicUnitTest
{
    public class BasicUnitTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            //int a;
            //int expected = 0;


            // Act
            //string actual = Program.CelciusToFahrenheit(a);
            //Assert.Equal(expected, actual);


            // Assert
        }

        [Theory]
        [InlineData(0, "C = 32F")]
        [InlineData(100, "C = 212F")]
        [InlineData(200, "C = 392F")]
        [InlineData(10, "C = 50F")]
        [InlineData(50, "C = 122F")]
        [InlineData(-300, "Temperature below absolute zero!")]

        static void CelciusToFahrenheitTest(double celcius, string expected)
        {
            string actual = Program.CelciusToFahrenheit(celcius);

            Assert.Equal(expected, actual);
        }

    }
}