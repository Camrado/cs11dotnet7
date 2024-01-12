using System.Numerics;

namespace Ch08Ex03NumbersAsWordsLib;

public static class NumberAsWord {
    private static Dictionary<int, string> smallNumbers = new() {
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"},
        {10, "Ten"},
        {11, "Eleven"},
        {12, "Twelve"},
        {13, "Thirteen"},
        {14, "Fourteen"},
        {15, "Fifteen"},
        {16, "Sixteen"},
        {17, "Seventeen"},
        {18, "Eighteen"},
        {19, "Nineteen"}
    };

    private static Dictionary<int, string> tens = new() {
        { 20, "Twenty" },
        { 30, "Thirty" },
        { 40, "Forty" },
        { 50, "Fifty" },
        { 60, "Sixty" },
        { 70, "Seventy" },
        { 80, "Eighty" },
        { 90, "Ninety" }
    };

    private static string[] postfixes = new string[] { 
        "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion" 
    };
    
    public static string ToWords(this int number) {
        return ToWords((BigInteger)number);
    }

    public static string ToWords(this long number) {
        return ToWords((BigInteger)number);
    }
    
    public static string ToWords(this BigInteger number) {
        if (number == 0) {
            return "Zero";
        }
        
        List<int> numberSeperatedBy3 = new();
        foreach (string threeNum in $"{number:N0}".Split(',')) {
            numberSeperatedBy3.Add(int.Parse(threeNum));
        }

        string result = "";
        for (int i = 0; i < numberSeperatedBy3.Count; i++) {
            if (string.IsNullOrEmpty(ThreeNumbersToWord(numberSeperatedBy3[i]))) {
                continue;
            }
            result += $", {ThreeNumbersToWord(numberSeperatedBy3[i])} {postfixes[numberSeperatedBy3.Count - i - 1]}";
        }

        return result.Substring(1).Trim();
    }

    private static string ThreeNumbersToWord(int number) {
        if (number == 0) {
            return "";
        }
        
        string result = "";

        if (number >= 100) {
            result += $" {smallNumbers[number / 100]} hundred";
            
            if (number % 100 != 0) {
                result += " and";
            }
            
            number %= 100;
        }
        
        if (number <= 19 && number > 0) {
            result += $" {smallNumbers[number]}";
        } else if (number >= 20) {
            result += $" {tens[(number / 10) * 10]}";

            if (number % 10 != 0) {
                number %= 10;
                result += $"-{smallNumbers[number]}";
            }
        }
        
        return result.Trim();
    }
}