namespace Lab4
{
    internal class Address
    {
        public string StreetAddress { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public int PostalCode { get; init; }

        public Address(string streetAddress, string city, string state, int postalCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{City} | {State} | {PostalCode}";
        }
    }
}
