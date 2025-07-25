using System;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace Test
{
    public class UnitTest1
    {

        [Fact]
        public void TestStringToInt()
        {
            //Test a good value(string can be converted to int)
            // ARRANGE
            int expected, actual;
            expected = 3;
            string input = "3";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestStringToIntNegativeValue()
        {
            //Test an int non-score value(negative)
            // ARRANGE
            int expected, actual;
            expected = -1;
            string input = "-2";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntStringValue()
        {
            //Test a string value (string cannot be converted to int, it's a string "st%$")
            // ARRANGE
            int expected, actual;
            expected = -1; // Business Logic 
            string input = "a string";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringtoIntDoubleValue()
        {
            //Test a decimal value (string cannot be converted to int, it's decimal/double)
            // ARRANGE
            int expected, actual;
            expected = -1;
            string input = "1.1";
            // ACT
            actual = Methods.Program.ConvertToInt(input);
            // ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidateInput()
        {
            // Test a good value(int is greater than zero)
            // ARRANGE
            int input = 6;
            // ACT
            // ASSERT
            Assert.True(Methods.Program.ValidateInput(input));
        }

        [Fact]
        public void TestValidateInputZero()
        {
            //Test edge case (int is zero)
            // ARRANGE
            int input = 0;
            // ACT
            // ASSERT
            Assert.True(Methods.Program.ValidateInput(input));
        }

        [Fact]
        public void TestValidateInputNegative()
        {

            //Test bad UnitTest1(int is less than zero)
            // ARRANGE
            int input = -5;
            // ACT
            // ASSERT
            Assert.False(Methods.Program.ValidateInput(input));
        }

    }
}
