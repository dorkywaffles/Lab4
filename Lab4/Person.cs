namespace Lab4
{
    internal class Person : IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Address Address { get; init; }

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public int CompareTo(Person? other)
        {
            return String.Compare(this.LastName, other.LastName);
        }

        public override string ToString()
        {
            return $"{FirstName} | {LastName} | {Address}";
        }
    }
}
