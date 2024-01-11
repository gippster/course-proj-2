public class Address
{
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public int ApartmentNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string PostCode { get; set; }

    public Address(string street, int houseNumber, int apartmentNumber, string city, string country, string postCode)
    {
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
        City = city;
        Country = country;
        PostCode = postCode;
    }
}
