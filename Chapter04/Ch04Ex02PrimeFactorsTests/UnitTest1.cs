using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests;

public class UnitTest1 {
    [Fact]
    public void Test1() {
        int number = 8;
        string expected = "2x2x2";

        string actual = PrimeFactorsLib.PrimeFactors(number);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test2() {
        int number = 24;
        string expected = "2x2x2x3";

        string actual = PrimeFactorsLib.PrimeFactors(number);
        
        Assert.Equal(expected, actual);
    }
}