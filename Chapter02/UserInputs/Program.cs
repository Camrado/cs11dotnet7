// using static System.Console;
// it is added to the .csproj of this project, so it will be automatically added to all files in this project.

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}.",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);

Write("Type your first name and press ENTER: ");

// The '?' after string means that we ARE expecting a possible 'null' value
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");

// The '!' at the end is called null-forgiving operator, and it tells the compiler that, in this case, ReadLine()
// will not return a 'null' value, so it can stop showing the warning.
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}.");

