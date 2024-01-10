using System.Text.RegularExpressions; // Regex

Write("Enter your age: ");
string input = ReadLine()!;

Regex ageChecker = new(@"^\d+$"); //  the regular expression only allows zero or positive whole numbers of any length

if (ageChecker.IsMatch(input)) {
    WriteLine("Thank you!");
} else {
    WriteLine($"This is not a valid age: {input}");
}