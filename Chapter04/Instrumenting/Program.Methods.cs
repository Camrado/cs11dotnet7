using System.Diagnostics; // Trace
using System.Runtime.CompilerServices; // [Caller...] attributes

partial class Program {
    static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string member = "",
        [CallerFilePath] string filepath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))] string expression = ""
        ) {
        Trace.WriteLine($"[{filepath}]\n {member} on line {line}. Expression: {expression}");
    }
}