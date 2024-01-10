string city = "London";
WriteLine($"{city} is {city.Length} characters long.");
WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array:");
foreach (string item in citiesArray) {
    WriteLine(item);
}

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

string fullName = "Alan Shore";
int indexOfTheSpace = fullName.IndexOf(' ');

string firstName = fullName.Substring(0, indexOfTheSpace);
string lastName = fullName.Substring(indexOfTheSpace + 1);

WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

string company = "Microsoft";
bool startsWithM = company.StartsWith("M");
bool endsWithN = company.EndsWith("N");
bool containsSoft = company.Contains("soft");

WriteLine($"Text: {company}");
WriteLine($"Starts with M: {startsWithM}, ends with N: {endsWithN}, contains soft: {containsSoft}");

