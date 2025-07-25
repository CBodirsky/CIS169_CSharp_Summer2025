using AddressClass;

namespace HouseClassComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address("123", "Elm Street", "2B", "Spooksville", "MO", "65432");
            House myHouse = new House(myAddress, 2, 1);

            Console.WriteLine(myHouse.ToString());
        }
    }
}
