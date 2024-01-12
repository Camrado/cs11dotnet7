using System.Numerics;
using Ch08Ex03NumbersAsWordsLib;

while (true) {
    Write("Enter a number (press Enter to exit): ");
    string? input = ReadLine();

    if (string.IsNullOrWhiteSpace(input)) {
        break;
    }

    BigInteger number = BigInteger.Parse(input);
    WriteLine(number.ToWords());
}
