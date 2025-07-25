
public class Student
{
    private string _firstName;
    private string _lastName;
    private DateTime _dateOfBirth;
    private int _studentID;

    // Properties
    // TODO
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }
    public int StudentID
    {
        get => _studentID;
        set => _studentID = value;
    }

    // Constructors
    public Student()
    {
        // TODO
        FirstName = "Unknown";
        LastName = "Unknown";
        DateOfBirth = DateTime.MinValue;
        StudentID = 0;

    }

    public Student(string fName, string lName, DateTime DOB, int ID)
    {
        // TODO
        FirstName = fName;
        LastName = lName;
        DateOfBirth = DOB;
        StudentID = ID;
    }

    // Add method
    public int CalculateAge()
    {
        var today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        if (DateOfBirth.Year < today.Year)
        {
            age = today.Year - DateOfBirth.Year;
            return age;
        }
        else
        {
            age = 0;
            return age;
        }

    }

    public virtual string MakeNamePlate()
    {
        return ToString();
    }
    public override string ToString()
    {
        return base.ToString() + "Name: " + FirstName + " " + LastName + " ID: " + StudentID;
    }
}