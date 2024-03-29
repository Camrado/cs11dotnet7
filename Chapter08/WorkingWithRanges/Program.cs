﻿string name = "Samantha Jones";

// getting the lengths of the first and last names
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

// using Substring
string firstName = name.Substring(0, lengthOfFirst);
string lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);

WriteLine($"First name: {firstName}, Last name: {lastName}");

// using Spans
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..^0];

WriteLine("First name: {0}, Last name: {1}",
    arg0: firstNameSpan.ToString(),
    arg1: lastNameSpan.ToString());
    
    
List<short> numberSeperatedBy3 = new();
foreach (string threeNum in $"{1235002:N0}".Split(',')) {
    numberSeperatedBy3.Add(short.Parse(threeNum));
}

foreach (var VARIABLE in numberSeperatedBy3) {
    WriteLine(VARIABLE);
}