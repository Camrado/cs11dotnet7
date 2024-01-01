using static System.Convert;

/*
 * An important difference between casting and converting is that converting rounds the
 * double value 9.8 up to 10 instead of trimming the part after the decimal point.
 */

// Casting...
int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
// int d = c; // compiler gives an error for this line
int d = (int) c;
WriteLine(d); // d is 9 losing the .8 part

long e = 10;
int f = (int) e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int) e;
WriteLine($"e is {e:N0} and f is {f:N0}");

// Converting...
double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");
