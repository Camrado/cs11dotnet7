partial class Program {
    static void SectionTitle(string title) {
        ConsoleColor previouscolor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("*");
        WriteLine($"* {title}");
        WriteLine("*");
        ForegroundColor = previouscolor;
    }
}