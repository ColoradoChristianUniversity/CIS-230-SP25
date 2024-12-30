namespace Shared.Tests.Services;

public class GeneratorTests
{
    [Fact]
    public void SamplePeople_Default_Returns10()
    {
        var people = Shared.Services.Generator.SamplePeople();

        Assert.Equal(10, people.Length);

        Assert.Equal(10, people.Select(p => p.Id).Distinct().Count());
    }

    [Fact]
    public void SamplePeople_0_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Shared.Services.Generator.SamplePeople(0));
    }

    [Fact]
    public void SamplePeople_11_Returns11()
    {
        var people = Shared.Services.Generator.SamplePeople(11);

        Assert.Equal(11, people.Select(p => p.Id).Distinct().Count());
    }
}