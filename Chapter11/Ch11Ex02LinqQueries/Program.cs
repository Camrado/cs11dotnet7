using Ch11Ex02LinqQueries;

using Northwind db = new();

IQueryable<string?> cities = db.Customers.Select(c => c.City).Distinct();

WriteLine(string.Join(", ", cities));
WriteLine();

Write("Enter the name of a city: ");
string city = ReadLine()!;

IQueryable<Customer> customers = db.Customers.Where(c => c.City == city);

WriteLine($"There are {customers.Count()} customers in {city}:");
foreach (var customer in customers) {
    WriteLine($"    {customer.CompanyName}");
}