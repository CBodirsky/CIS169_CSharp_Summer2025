public class StudentWorker : Student
{
    private decimal _hourlyRate;
    private double _hoursWorked;

    // Properties
    public decimal HourlyRate
    {
        get => _hourlyRate;
        set
        {
            if (value >= 7.25M && value <= 14.75M) //checks range of rate
            {        
                _hourlyRate = value;
            }
            else
            {
                _hourlyRate = 0M; //issues will cause pay to be zero when multiplied with rate
            }
        }
    }

    public double HoursWorked
    {
        get => _hoursWorked;
        set
        {
            if (value >= 1 && value <= 15) //checks range
            {
                _hoursWorked = value;
            }
            else
            {
                _hoursWorked = 0; //also results in zero pay to be checked
            }
        }
    }

    // Constructor
    public StudentWorker(decimal rate, double hours, string fName, string lName, DateTime dob, int id)
        : base(fName, lName, dob, id)
    {
        HourlyRate = rate;
        HoursWorked = hours;
    }

    // Override ToString
    public override string ToString()
    {
        return base.ToString() +
    $"\nAge: {CalculateAge()} years" +
    $"\nHours Worked: {HoursWorked}" +
    $"\nHourly Rate: ${HourlyRate:F2}" +
    $"\nTotal Pay: ${CalculatePay():F2}";
    }

    // Override MakeNamePlate
    public override string MakeNamePlate()
    {
        return $"{LastName}, {FirstName} - Pay Rate: ${HourlyRate:F2}";
    }

    // CalculatePay method
    public decimal CalculatePay()
    {
        return HourlyRate * (decimal)HoursWorked;
    }
}
