namespace MyCalculatorTestApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _sut = new();

    [Theory]
    [InlineData(4, 3, 7)]
    [InlineData(21, 5.25, 26.25)]
    [InlineData(double.MaxValue, 5, double.MaxValue)]
    public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
    {
        // Arrange


        // Act
        double actual = _sut.Add(x, y);

        // Assert
        Assert.Equal(expected, actual);

    }

    [Theory]
    [InlineData(8, 4, 2)]
    [InlineData(8, 0, 0)]
    public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
    {
        // Arrange
        //CalculatorViewModel sut = new();

        // Act
        double actual = _sut.Divide(x, y);

        // Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void Divide_DivideByZero()
    {
        // Arrange
        //CalculatorViewModel sut = new();
        double expected = 0;

        // Act
        double actual = _sut.Divide(15, 0);

        // Assert
        Assert.Equal(expected, actual);

    }
}
