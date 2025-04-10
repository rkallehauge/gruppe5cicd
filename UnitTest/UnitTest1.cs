using CICDGruppe5;
using System.Formats.Asn1;

namespace UnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void Addition()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(110, calculator.Add(99, 11));
        }

        [Fact]
        public void Subtraction()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(20, calculator.Subtract(50, 30));
        }

        [Fact]
        public void Multiplication()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(100, calculator.Multiply(10, 10));
        }

        [Fact]
        public void Division()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(5, calculator.Divide(50, 10));
        }

        [Fact]
        public void NullCheck()
        {
            Calculator calculator = new Calculator();
            Assert.Null(calculator.Divide(126598246982456, 0));
        }
    }
}
