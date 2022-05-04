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
}