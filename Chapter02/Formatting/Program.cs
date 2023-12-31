using static System.Console;

int numberOfApples = 12;
float test = 111111.3523f;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}. Test: {2:N0}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples,
    arg2: test);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
    
    
// Three parameter values can use named arguments.
WriteLine(
    format: "{0} {1} lived in {2}.",
    arg0: "Roger", arg1: "Cevung",
    arg2: "Stockholm");

// Five or more parameter values cannot use named arguments.
WriteLine(
    format: "{0} {1} lived in {2}, {3} and worked in the {4} team at {5}.",
    "Roger", "Cevung", "Stockholm", "Sweden", "Education", "Optimizely");
    

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");
WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);
WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);    