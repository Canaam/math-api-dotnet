using MathApi.Services;
using Xunit;

public class NumberTests
{
    private readonly Number _number = new Number();


    [Fact]
    public void Sum_ShouldReturnCorrectResult()
    {
        var result = _number.Sum(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Sum_NegativeNumbers_ShouldReturnCorrectResult()
    {
        var result = _number.Sum(-5, -10);
        Assert.Equal(-15, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectResult()
    {
        var result = _number.Divide(10, 2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => _number.Divide(10, 0));
    }

    [Fact]
    public void Divide_NegativeNumbers_ShouldReturnCorrectResult()
    {
        var result = _number.Divide(-10, 2);
        Assert.Equal(-5, result);
    }
}