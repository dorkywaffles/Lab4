using Lab4;
{
    var root = FileRoot.fileRoot;
    char dirSep = Path.DirectorySeparatorChar;
    var csvfile = root + dirSep + "data" + dirSep + "data.csv";
    var psvfile = root + dirSep + "data" + dirSep + "data.psv";
    var people = new List<Person>();

    using (var sr = new StreamReader(csvfile))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            var info = line.Split(",");
            var firstName = info[0];
            var lastName = info[1];
            Address address = new Address(info[2], info[3], info[4], Int32.Parse(info[5]));

            people.Add(new Person(firstName, lastName, address));
        }
    }

    people.Sort();

    using (var sw = new StreamWriter(psvfile))
    {
        foreach (Person person in people)
        {
            string line = $"{person.FirstName} | {person.LastName} | {person.Address}";
        }
    }
}