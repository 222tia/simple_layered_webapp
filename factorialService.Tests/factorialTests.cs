using Xunit;
namespace factorialService.Tests;

public class factorialTests
{
    [Fact]
    public void testFactorialValue_0(){
        Assert.Equal(1,factorial.getFactorial(0))
    }

    [Fact]
    public void testFactorialValue_5(){
        Assert.Equal(120,factorial.getFactorial(5))
    }

}