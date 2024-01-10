using System.Numerics;

WriteLine("Working with large integer:");
WriteLine("---------------------------");

ulong big = ulong.MaxValue;
WriteLine($"{big,40:N0}");

BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
WriteLine($"{bigger,40:N0}");

WriteLine("Working with complex numbers:");

Complex c1 = new(4,2);
Complex c2 = new(3,7);
Complex c3 = c1 + c2;

WriteLine($"{c1} added to {c2} is {c3}");

WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
    c1.Real, c1.Imaginary,
    c2.Real, c2.Imaginary,
    c3.Real, c3.Imaginary);

// Random r = new();    
Random r = Random.Shared; // to avoid allocating more memory

int dieRoll = r.Next(minValue: 1, maxValue: 7); // returns 1 to 6

double randomReal = r.NextDouble(); // returns 0.0 to lest than 1.0

byte[] arrayOfBytes = new byte[256];
r.NextBytes(arrayOfBytes); // 256 random bytes in an array



