using Xunit;
namespace factorialService.Tests;

public class factorialTests
{
    [Fact]
    public void testFactorialValue_0(){
        Assert.Equal(1,Factorial.getFactorial(0))
    }

    [Fact]
    public void testFactorialValue_5(){
        Assert.Equal(120,Factorial.getFactorial(5))
    }

}