namespace Service.Library.Tests;

public class EndpointsTests
{
    [Fact]
    public void Now_ReturnsValue()
    {
        var now = Endpoints.GetNow(null!);

        Assert.NotEmpty(now);
    }
}
