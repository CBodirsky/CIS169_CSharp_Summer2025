using System;
using Xunit;
using AddressClass; // Namespace of Address class 

namespace XUnitTestProject1
{
    public class UnitTestAddress
    {
        [Fact]
        public void TestAddressCorrect()
        {
            // ARRANGE
            string actual, expected = "123 Main Street Apt H2\nSmall Town, Iowa 55555";
            Address testAddy = new Address("123", "Main Street", "H2", "Small Town", "Iowa", "55555");

            // ACT
            actual = testAddy.ToString();

            // ASSERT 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAddressNoApt()
        {
            // ARRANGE
            string actual, expected = "126 Main Street\nSmall Town, Iowa 55555";
            Address testAddy = new Address("126", "Main Street", "Small Town", "Iowa", "55555");

            // ACT
            actual = testAddy.ToString();

            // ASSERT 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAddressDefault()
        {
            // ARRANGE
            string actual, expected = "123 Main Street Apt H2\nSmall Town, Iowa 55555";
            Address testAddy = new Address();

            // Properties individually set
            testAddy.StreetNumber = "123";
            testAddy.StreetName = "Main Street";
            testAddy.Apt = "H2";
            testAddy.City = "Small Town";
            testAddy.State = "Iowa";
            testAddy.Zip = "55555";

            // ACT
            actual = testAddy.ToString();

            // ASSERT 
            Assert.Equal(expected, actual);
        }
    }
}
