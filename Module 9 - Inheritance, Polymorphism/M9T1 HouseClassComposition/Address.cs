/***************************************************************
* Name       : HouseClassComposition
* Author      : Chris Bodirsky
* Created    : 07/05/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program prints out addresses
*               from a one class through another
*               class.
*               Input:  None
*               Output: House listings
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace AddressClass
{
    public class Address
    {
        //Fields
        //Street number, Street name, Apt (if any), City, State, Zip
        private string streetNumber = "";
        private string streetName = "";
        private string apt = "";
        private string city = "";
        private string state = "";
        private string zip = "";
        //Constructors
        // Main constructor with all fields
        public Address(string streetNumber, string streetName, string apt, string
        city, string state, string zip)
        {
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.apt = apt;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
        // Parameterless constructor for default initialization
        public Address() { }
        // Optional convenience constructor without apartment number
        public Address(string streetNumber, string streetName, string city, string
        state, string zip)
        : this(streetNumber, streetName, "", city, state, zip) { }
        //Field properties
        //Street number, Street name, Apt (if any), City, State, Zip
        public string StreetNumber
        {
            get => streetNumber; set => streetNumber =
        value;
        }
        public string StreetName { get => streetName; set => streetName = value; }
        public string Apt { get => apt; set => apt = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        //necessary methods
        public override string ToString()
        {
            string firstLine = $"{StreetNumber} {StreetName}";
            if (!string.IsNullOrWhiteSpace(Apt))
            {
                firstLine += $" Apt {Apt}";
            }
            string secondLine = $"{City}, {State} {Zip}";
            return $"{firstLine}\n{secondLine}";
        }
    }
}