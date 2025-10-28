namespace assignment2.Tests;

public class GcdCalculatorTests
{
    [Fact]
    public void CalculateGcd_ShouldReturnCorrectValue()
    {
        Assert.Equal(6, GcdCalculator.CalculateGcd(48, 18));
        Assert.Equal(1, GcdCalculator.CalculateGcd(12, 5));
        Assert.Equal(3, GcdCalculator.CalculateGcd(18, 3));
        Assert.Equal(4, GcdCalculator.CalculateGcd(24, 4));
        Assert.Equal(2, GcdCalculator.CalculateGcd(30, 2));
    }

    [Fact]
    public void CaculateGcdArray_ShouldReturnExpectedArray()
    {
        int[] array1 = { 12, 18, 24, 30 };
        int[] array2 = { 5, 3, 4, 2 };

        int[] expected = { 1, 3, 4, 2 };

        var result = GcdCalculator.CalculateGcdArray(array1, array2);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculateArrayGcd_ShouldThrowIfLengthsDiffer()
    {
        int[] array1 = { 12, 18, 24 };
        int[] array2 = { 5, 3, 4, 2 };

        Assert.Throws<System.ArgumentException>(() =>
            GcdCalculator.CalculateGcdArray(array1, array2));
    }
}
