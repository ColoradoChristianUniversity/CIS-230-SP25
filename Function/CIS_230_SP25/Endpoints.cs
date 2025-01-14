using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using static CIS_230_SP25.Logic;

namespace CIS_230_SP25;

public class Endpoints
{
    [Function("StringArray")]
    public IActionResult RunStringArray([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
    {
        var index = ReadOptionalIndex(req);
        var result = GenerateStringArray(index);
        return new OkObjectResult(result);
    }

    [Function("IntegerArray")]
    public IActionResult RunIntegerArray([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
    {
        var index = ReadOptionalIndex(req);
        var result = GenerateIntegerArray(index);
        return new OkObjectResult(result);
    }

    [Function("States")]
    public IActionResult RunStates([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
    {
        var result = GenerateStates();
        return new OkObjectResult(result.Select(s => new { s.StateCode, State = s.Name }));
    }

    [Function("Capitals")]
    public IActionResult RunCapitals([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
    {
        var result = GenerateCapitals();
        return new OkObjectResult(result.Select(s => new { s.StateCode, City = s.Name }));
    }

    private static int ReadOptionalIndex(HttpRequestData req)
    {
        if (req is null)
        {
            return Random.Shared.Next(6);
        }
        var queryParameters = System.Web.HttpUtility.ParseQueryString(req.Url.Query);
        return int.TryParse(queryParameters["index"], out var parsedIndex) ? parsedIndex : Random.Shared.Next(6);
    }
}
