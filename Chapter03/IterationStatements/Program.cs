string? password;
do {
    Write("Enter your password: ");
    password = ReadLine();
} while (password != "Pa$$w0rd");
WriteLine("Correct!");