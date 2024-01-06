using Packt.Shared;

Person harry = new() {
    Name = "Harry",
    DateOfBirth = new(2001, 3, 25)
};

harry.WriteToConsole();

// non-generic lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(1, "Alpha");
lookupObject.Add(2, "Beta");
lookupObject.Add(3, "Gamma");
lookupObject.Add(harry, "Delta");

int key = 2; // look up the value that has 2 as its key
WriteLine($"Key {key} has value: {lookupObject[key]}");
WriteLine($"Key {harry} has value: {lookupObject[harry]}");

// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(1, "Alpha");
lookupIntString.Add(2, "Beta");
lookupIntString.Add(3, "Gamma");
lookupIntString.Add(4, "Delta");

key = 3;
WriteLine($"Key {key} has value: {lookupIntString[key]}");

// assign a method to the Shout delegate
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;

// call the Poke method that raises the Shout event
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Person?[] people = {
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

OutputPeopleNames(people, "Initial list of people: ");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation: ");

Array.Sort(people, new PersonComparer());
OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation:");
