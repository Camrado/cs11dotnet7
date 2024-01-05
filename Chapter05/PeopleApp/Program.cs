using System.Security.Cryptography;
using Packt.Shared;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}");
WriteLine($"{bob.Name}'s favourite wonder is {bob.FavouriteAncientWonder}. Its integer is {(int)bob.FavouriteAncientWonder}.");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
WriteLine(bob.OptionalParameters(number: 52.6, command: "Fight!"));

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach (Person child in bob.Children) {
    WriteLine($"> {child.Name}");
}

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");
var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

// store return value in a tuple variable with two fields
(string TheName, int TheNumber) tupleWithNamedFields = bob.GetNamedFruit();
// tupleWithNamedFields.TheName
// tupleWithNamedFields.TheNumber

// deconstruct return value into two separate variables
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// Deconstructing a Person
var (name1, dob1) = bob; // implicitly calls the Deconstruct method
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

Person alice = new() {
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");

BankAccount.InterestRate = 0.012M; // store a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance*BankAccount.InterestRate:C}");

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance*BankAccount.InterestRate:C}");

Person blankPerson = new();
WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on {blankPerson.Instantiated:dddd}");

Person gunny = new("Gunny", "Mars");
WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on {blankPerson.Instantiated:dddd}");

Person sam = new() {
    Name = "Sam",
    DateOfBirth = new(1969, 6, 25)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavouriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favourite ice-cream flavor is {sam.FavouriteIceCream}.");

string color = "Red";
try {
    sam.FavouritePrimaryColor = color;
    WriteLine($"Sam's favourite primary color is {sam.FavouritePrimaryColor}");
} catch (Exception ex) {
  WriteLine($"Tried to set {nameof(sam.FavouritePrimaryColor)} to '{color}': {ex.Message}");  
}

sam.Children.Add(new() {Name = "Charlie", DateOfBirth = new(2010,3,18)});
sam.Children.Add(new() {Name = "Ella", DateOfBirth = new(2020,12,24)});

// get using Children list
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

// get using integer position indexer
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

// get using name indexer
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

// Book book = new() {
//     Isbn = "978-1803237800",
//     Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
// };

Book book = new("978-1803237800", "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals") {
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine($"{book.Isbn}: {book.Title} written by {book.Author} has {book.PageCount:N0} pages.");


Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);
// Person.Marry(zillah, lamech);
if (zillah + lamech) {
    WriteLine($"{zillah.Name} and {lamech.Name} successfully got married.");
}

WriteLine($"{lamech.Name} is married to {lamech.Spouse?.Name ?? "nobody"}");
WriteLine($"{adah.Name} is married to {adah.Spouse?.Name ?? "nobody"}");
WriteLine($"{zillah.Name} is married to {zillah.Spouse?.Name ?? "nobody"}");

// call instance method 
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");

// call static method
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

// use operator to "multiply"
Person baby3 = lamech * adah;
baby3.Name = "Jubal";

Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

WriteLine($"{lamech.Name} has {lamech.Children.Count} children.");
WriteLine($"{adah.Name} has {adah.Children.Count} children.");
WriteLine($"{zillah.Name} has {zillah.Children.Count} children.");

for (int i = 0; i < lamech.Children.Count; i++) {
    WriteLine(format: "{0}'s child #{1} is named \"{2}\".",
        arg0: lamech.Name, arg1: i, arg2: lamech[i].Name);
}