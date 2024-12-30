using System;
using Bogus;

namespace Shared.Services;

public class Generator
{
    private const int Seed = 1234;

    public static Models.Person[] SamplePeople(int count = 10)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(count, 0, nameof(count));

        Randomizer.Seed = new Random(Seed);

        var faker = new Faker<Models.Person>()
            .RuleFor(p => p.Id, f => new Guid(f.Random.Bytes(16)))
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName());

        return [.. faker.Generate(count)];
    }
}