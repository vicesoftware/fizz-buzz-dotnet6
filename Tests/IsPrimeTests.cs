using Xunit;
using ViceSoftware.Services;
using FizzBuzz;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var primeService = new PrimeService();
        string result = primeService.IsPrime(1);

        Assert.Equal(result, "1");
    }

    [Fact]
    public void Test2()
    {
        var primeService = new PrimeService();
        string result = primeService.IsPrime(11);

        Assert.Equal(result, "Quartz");
    }

    
}