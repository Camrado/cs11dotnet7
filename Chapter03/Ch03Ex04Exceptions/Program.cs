Write("Enter a number between 0 and 255: ");
string? firstNum = ReadLine();
    
Write("Enter another number between 0 and 255: ");
string? secondNum = ReadLine();

try {
    byte n1 = byte.Parse(firstNum);
    byte n2 = byte.Parse(secondNum);
    
    WriteLine($"{n1} divided by {n2} is {n1/n2}");
} catch (FormatException) {
    WriteLine("FormatException: Please enter a number.");
} catch (OverflowException) {
    WriteLine("OverflowException: Enter a number between 0 and 255.");
} catch (Exception e) {
    WriteLine(e.GetType());
}
// and many other exceptions...