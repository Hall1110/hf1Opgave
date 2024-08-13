using Basic;

namespace BasicUnitTest
{
    public class BasicUnitTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int expected = 0;


            // Act
            int actual = Program.ElementaryOperations(a, b);
            Assert.Equal(expected, actual);


            // Assert
        }
    }
}