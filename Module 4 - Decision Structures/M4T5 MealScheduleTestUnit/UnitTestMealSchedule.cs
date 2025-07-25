using System;
using Xunit;

namespace XUnitTestMealSchedule
{
    public class UnitTestMealSchedule
    {
        [Fact]
        public void TestMondayLunch()
        {
            // Arrange
            string day = "Monday";
            string mealTime = "lunch";

            string expected = "VeggieBurger and Fries";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMondayDinner()
        {
            // Arrange
            string day = "Monday";
            string mealTime = "dinner";

            string expected = "Lasagna";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTuesdayLunch()
        {
            // Arrange
            string day = "Tuesday";
            string mealTime = "lunch";

            string expected = "Chili and cornbread";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTuesdayDinner()
        {
            // Arrange
            string day = "Tuesday";
            string mealTime = "dinner";

            string expected = "Pizza";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWednesdayLunch()
        {
            // Arrange
            string day = "Wednesday";
            string mealTime = "lunch";

            string expected = "Pad Thai";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWednesdayDinner()
        {
            // Arrange
            string day = "Wednesday";
            string mealTime = "dinner";

            string expected = "Soup and Salad";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestThursdayLunch()
        {
            // Arrange
            string day = "Thursday";
            string mealTime = "lunch";

            string expected = "Baked Potato";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestThursdayDinner()
        {
            // Arrange
            string day = "Thursday";
            string mealTime = "dinner";

            string expected = "Spaghetti";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestBadInputMealTime()
        {
            // Arrange
            string day = "Tuesday";
            string mealTime = "breakfast";

            string expected = "Ice Cream!";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestBadInputDay()
        {
            // Arrange
            string day = "Blursday";
            string mealTime = "dinner";

            string expected = "Ice Cream!";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        //Attempting extra credit unit tests

        [Fact]
        public void TestFridayLunch()
        {
            // Arrange
            string day = "Friday";
            string mealTime = "lunch";

            string expected = "Hotdog";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSaturdayDinner()
        {
            // Arrange
            string day = "Saturday";
            string mealTime = "dinner";

            string expected = "Burrito";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSundayLunch()
        {
            // Arrange
            string day = "Sunday";
            string mealTime = "lunch";

            string expected = "Chicken Wings";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestBadInputExtraDays()
        {
            // Arrange
            string day = "Stunday";
            string mealTime = "diner";

            string expected = "Ice Cream!";
            string actual;

            // Act
            actual = Module4.Program.DecideMeal(day, mealTime);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
