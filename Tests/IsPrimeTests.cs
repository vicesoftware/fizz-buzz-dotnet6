using Xunit;
using ViceSoftware.Services;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(1);

        Assert.False(result, "1 should not be prime");
    }

    [Fact]
    public void Test3()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(3);

        Assert.True(result, "3 should be prime");
    }

    [Fact]
    public void Test4()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(4);

        Assert.False(result, "4 should not be prime");
    }

    [Fact]
    public void Test5()
    {
        var primeService = new PrimeService();
        bool result = primeService.IsPrime(5);

        Assert.True(result, "5 should be prime");
    }
}