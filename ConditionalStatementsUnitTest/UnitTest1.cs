using ConditionalStatements;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Data;


namespace ConditionalStatementsUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            

            // Act


            
            // Assert


        }
        [Theory]
        [InlineData(1940, true)]
        [InlineData(1980, true)]
        [InlineData(2024, true)]
        [InlineData(1989, false)]
        [InlineData(2006, false)]
        [InlineData(2014, false)]

        public void IfLeapYearUnitTest(int year, bool expected)
        {

            bool actual = ConditionalStatementsProgram.IfLeapYear(year);

            Assert.Equal(expected, actual);
        }
    }
}