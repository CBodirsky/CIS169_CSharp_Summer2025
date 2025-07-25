using AddressClass;
public class House
{
    // Fields are private, names use underscore and camelCasing
    private Address _houseAddress;
    public Address HouseAddress
    {
        get => _houseAddress; 
        set => _houseAddress = value;
    }

    private int _numberOfBedrooms;
    private int _numberOfBathrooms;
    // Constructors
    // Default no-arg Constructor
    public House()
    {
        _houseAddress = new Address();
        NumberOfBedrooms = 0;
        NumberOfBathrooms = 0;
    }
    // Parameterized Constructor
    public House(Address address, int numberOfBathrooms, int numberOfBedrooms)
    {
        HouseAddress = address;
        NumberOfBathrooms = numberOfBathrooms;
        NumberOfBedrooms = numberOfBedrooms;
    }
    // Properties public access and PascalCase
    // Another way to set and get values 
    public int NumberOfBedrooms
    {
        get => _numberOfBedrooms;
        set => _numberOfBedrooms = value;
    }
    public int NumberOfBathrooms
    {
        get => _numberOfBathrooms;
        set => _numberOfBathrooms = value;
    }
    // ToString method to print class object
    // It is public and has keyword override
    public override string ToString()
    {
        return ("House at " + HouseAddress.ToString() + " has " +
            NumberOfBedrooms + " bedrooms and " +
            NumberOfBathrooms + " bathrooms.");
    }
}