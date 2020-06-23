using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculatorStarter
{
    public class CalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            var calculator = new Calculator();
            
            var result = calculator.Add("");

            Assert.Equal(0, result);
        }
    }
}
