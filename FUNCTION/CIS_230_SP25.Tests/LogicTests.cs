using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker.Http;

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
}
