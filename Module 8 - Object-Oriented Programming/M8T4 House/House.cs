namespace HouseClass
{
    // Class is public here, name is PascalCase
    public class House
    {
        // Fields are private, names use underscore and camelCasing
        private string _address;
        private int _numberOfBedrooms;
        private int _numberOfBathrooms;
        // Constructors
        // Default no-arg Constructor
        public House()
        {
            Address = "";
            NumberOfBedrooms = 0;
            NumberOfBathrooms = 0;
        }
        // Parameterized Constructor
        public House(string address, int numberOfBathrooms, int numberOfBedrooms)
        {
            Address = address;
            NumberOfBathrooms = numberOfBathrooms;
            NumberOfBedrooms = numberOfBedrooms;
        }
        // Properties public access and PascalCase
        // Another way to set and get values 
        public string Address
        {
            get => _address;
            set => _address = value;
        }
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
            return ("House at " + Address + " has " +
                NumberOfBedrooms + " bedrooms and " +
                NumberOfBathrooms + " bathrooms.");
        }
    }
}