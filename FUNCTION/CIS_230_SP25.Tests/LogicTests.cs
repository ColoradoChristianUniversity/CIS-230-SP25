namespace CIS_230_SP25.Tests;

public class LogicTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void StringArray_ValidIndex_ReturnsArray(int index)
    {
        // Act
        var result = Logic.GenerateStringArray(index);

        // Assert
        Assert.IsType<string[]>(result);
        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IntegerArray_ValidIndex_ReturnsArray(int index)
    {
        // Act
        var result = Logic.GenerateIntegerArray(index);

        // Assert
        Assert.IsType<int[]>(result);
        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }

    [Fact]
    public void StatesCapitals_JoinStateCode_ReturnsFifty()
    {
        // Act
        var states = Logic.GenerateStates();
        var capitals = Logic.GenerateCapitals();
        var combination = states.Join(capitals, s => s.StateCode, c => c.StateCode, (s, c) => new { City = s.Name, State = c.Name });

        // Assert
        Assert.Equal(50, states.Length);
        Assert.Equal(50, capitals.Length);
        Assert.Equal(50, combination.Count());
    }
}
