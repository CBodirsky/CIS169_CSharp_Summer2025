using MedalWinnerMethods;
namespace UnitTests
{
    public class MedalWinnerUnitTest
    {
        [Fact]
        public void PassingCaseTest()
        {
            // Arrange
            string fName = "Megan";
            string lName = "RAPINOE";
            string rank = "1";
            string expected = "Megan RAPINOE 1";
            string actual;
            // Act
            actual = MedalWinner.FormatName(fName, lName, rank);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LastNameFormatTest()
        {
            // Arrange
            string fName = "Megan";
            string lName = "rapinoe";
            string rank = "1";
            string expected = "Megan RAPINOE 1";
            string actual;
            // Act
            actual = MedalWinner.FormatName(fName, lName, rank);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FirstNameFormatTest()
        {
            // Arrange
            string fName = "megan";
            string lName = "RAPINOE";
            string rank = "1";
            string expected = "Megan RAPINOE 1";
            string actual;
            // Act
            actual = MedalWinner.FormatName(fName, lName, rank);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RankExceptionHandledTest()
        {
            // Arrange
            string fName = "USA";
            string lName = "Women's Soccer";
            string rank = "1.5";
            string expected = "Usa WOMEN'S SOCCER 1.5";
            string actual;
            // Act
            actual = MedalWinner.FormatName(fName, lName, rank);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}