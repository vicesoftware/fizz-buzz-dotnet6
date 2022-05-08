using Xunit;
using ViceSoftware.Services;
using FizzBuzz;

namespace Tests;

public class UnitTest2
{
    [Fact]
    public void Test3(){
        var fb = new FizzBuzzer();
        var str = fb.doTheFizzBuzz(new string[] {"3","5","7", "15"});
        Assert.Equal(new string[] {"Fizz", "Buzz", "7", "FizzBuzz"}, str);
    }

    // I would put a test here with IsPrime sent in the 
    // moreMaths array, but the testing suite does not 
    // appreciate me trying to import Func<int, string>[]
    // into this context

    
}