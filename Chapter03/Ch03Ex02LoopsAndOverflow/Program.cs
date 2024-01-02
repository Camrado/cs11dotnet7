try {
    int max = 500;

    checked {
        for (byte i = 0; i < max; i++) {
            WriteLine(i);
        }
    }
} catch (OverflowException e) {
    WriteLine("Overflow Exception");
}
