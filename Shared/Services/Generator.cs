using Bogus;

namespace Shared.Services;

public class Generator
{
    public static Models.Person[] SamplePeople(int count = 10)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(count, 0);

        var faker = new Faker<Models.Person>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1) 
            .RuleFor(p => p.FirstName, f => f.Name.FirstName()) 
            .RuleFor(p => p.LastName, f => f.Name.LastName());  

        Randomizer.Seed = new Random(1234); 
        return faker.Generate(count).ToArray();
    }
}