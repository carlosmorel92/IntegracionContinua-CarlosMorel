using Xunit;
using Project;

namespace Project.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2,3));
        }

        [Fact]
        public void Divide_ByNonZero_ReturnsQuotient()
        {
            var calc = new Calculator();
            Assert.Equal(2, calc.Divide(6,3));
        }
    }
}
