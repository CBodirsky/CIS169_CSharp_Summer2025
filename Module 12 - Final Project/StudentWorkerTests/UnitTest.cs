using Xunit;
using StudentEntry;


    public class StudentWorkerTests
    {
        // Test 1: Invalid hours (too low)
        [Fact]
        public void HoursWorkedTooLow_ShouldReturnZeroPay()
        {
            // Arrange
            var worker = new StudentWorker(10.00M,-10, "Test", "Case", DateTime.Parse("2000-01-01"), 1);
            // Act
            decimal actual = worker.CalculatePay();
            decimal expected = 0.00M;
            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 2: Invalid hours (too high)
        [Fact]
        public void HoursWorkedTooHigh_ShouldReturnZeroPay()
        {
            var worker = new StudentWorker(10.00M, 30, "Test", "Case", DateTime.Parse("2000-01-01"), 1);
            // Act
            decimal actual = worker.CalculatePay();
            decimal expected = 0.00M;
            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 3: Invalid hourly rate (too low)
        [Fact]
        public void HourlyRateTooLow_ShouldReturnZeroPay()
        {
            var worker = new StudentWorker(5.00M, 10, "Test", "Case", DateTime.Parse("2000-01-01"), 1);
            // Act
            decimal actual = worker.CalculatePay();
            decimal expected = 0.00M;
            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 4: Invalid hourly rate (too high)
        [Fact]
        public void HourlyRateTooHigh_ShouldReturnZeroPay()
        {
            var worker = new StudentWorker(30.00M, 10, "Test", "Case", DateTime.Parse("2000-01-01"), 1);
            // Act
            decimal actual = worker.CalculatePay();
            decimal expected = 0.00M;
            // Assert
            Assert.Equal(expected, actual);
        }

        // Test 5: Valid input
        [Fact]
        public void ValidInput_ShouldReturnCorrectPay()
        {
            // Arrange
            var worker = new StudentWorker(10.00M, 10, "Test", "Case", DateTime.Parse("2000-01-01"), 1);
            // Act
            decimal actual = worker.CalculatePay();
            decimal expected = 100.00M;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
