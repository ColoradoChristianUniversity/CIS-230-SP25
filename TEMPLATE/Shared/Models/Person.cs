using System.Text.Json.Serialization;

namespace Shared.Models;

public class Person
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = "";

    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = "";
}