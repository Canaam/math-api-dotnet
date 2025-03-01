using MathApi.Services;
using Xunit;

public class NumbersTests
{
    private readonly Numbers _numbers = new Numbers();


    [Fact]
    public void Sum_ShouldReturnCorrectSum()
    {
        var result = _numbers.Sum(new int[] { 1, 2, 3, 4 });
        Assert.Equal(10, result);
    }

    [Fact]
    public void Sum_EmptyArray_ShouldReturnZero()
    {
        var result = _numbers.Sum(new int[] { });
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_NullArray_ShouldReturnZero()
    {
        var result = _numbers.Sum(null);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_NegativeNumbers_ShouldReturnCorrectSum()
    {
        var result = _numbers.Sum(new int[] { -1, -2, -3 });
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Sum_LargeNumbers_ShouldHandleOverflow()
    {
        var exception = Assert.Throws<OverflowException>(() =>
            _numbers.Sum(new int[] { int.MaxValue, int.MaxValue }));

        Assert.Equal("A soma dos números excede o limite de um inteiro (int).", exception.Message);
    }

    // Testes para o método Average
    [Fact]
    public void Average_ShouldReturnCorrectAverage()
    {
        var result = _numbers.Average(new int[] { 10, 20, 30 });
        Assert.Equal(20, result);
    }

    [Fact]
    public void Average_EmptyArray_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _numbers.Average(new int[] { }));
    }

    [Fact]
    public void Average_NullArray_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _numbers.Average(null));
    }

    [Fact]
    public void Average_NegativeNumbers_ShouldReturnCorrectAverage()
    {
        var result = _numbers.Average(new int[] { -10, -20, -30 });
        Assert.Equal(-20, result);
    }

    [Fact]
    public void Average_SingleNumber_ShouldReturnTheNumber()
    {
        var result = _numbers.Average(new int[] { 5 });
        Assert.Equal(5, result);
    }
}