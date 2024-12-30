using System.Net;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using static CIS_230_SP25.Logic;

namespace CIS_230_SP25;

public class Endpoints
{
    [Function("StringArray")]
    public HttpResponseData RunStringArray([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        var result = GenerateStringArray(ReadOptionalIndex(req));
        return CreateOkResponse(req, result);
    }

    [Function("IntegerArray")]
    public HttpResponseData RunIntegerArray([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        var result = GenerateIntegerArray(ReadOptionalIndex(req));
        return CreateOkResponse(req, result);
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

    private static HttpResponseData CreateOkResponse(HttpRequestData req, object result)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);
        var json = JsonSerializer.Serialize(result);
        response.WriteString(json);
        return response;
    }
}
