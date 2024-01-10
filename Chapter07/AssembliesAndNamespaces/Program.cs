using SharedLibrary;

Write("Enter a color value in hex: ");
string? hex = ReadLine(); // or "00ffc8"
WriteLine($"Is {hex} a valid color? {hex.IsValidHex()}");

Write("Enter an XML element: ");
string? xmlTag = ReadLine(); // or "<h1 />"
WriteLine($"Is {xmlTag} a valid XML element? {xmlTag.IsValidXmlTag()}");

Write("Enter a password: ");
string? password = ReadLine(); // or "secretsauce"
WriteLine($"Is {password} a valid password? {password.IsValidPassword()}");
