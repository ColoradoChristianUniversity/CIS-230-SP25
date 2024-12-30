using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Service.Library.Health;

public class NowServiceHealthCheck : IHealthCheck
{
    private const int ResponseTimeThresholdMs = 1_000;

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var url = GetUrlFromContext(context);
        var (milliseconds, result, statusCode) = await GetAsync(url, cancellationToken);

        var healthData = new Dictionary<string, object>
        {
            { "response-time-ms", milliseconds },
            { "response-threshold-ms", ResponseTimeThresholdMs },
            { "response-status-code", statusCode },
            { "response-content", string.IsNullOrEmpty(result) ? "empty" : result }
        };

        if (statusCode != 200 || string.IsNullOrEmpty(result) || milliseconds > ResponseTimeThresholdMs)
        {
            return HealthCheckResult.Unhealthy(data: healthData);
        }

        return HealthCheckResult.Healthy(data: healthData);
    }

    private static string GetUrlFromContext(HealthCheckContext context)
    {
        // Assuming the URL and port are passed as parameters in the context
        var url = context.Registration.Tags.FirstOrDefault(tag => tag.StartsWith("url="))?.Substring(4);
        var port = context.Registration.Tags.FirstOrDefault(tag => tag.StartsWith("port="))?.Substring(5);

        if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(port))
        {
            throw new InvalidOperationException("URL or port not specified in health check context.");
        }

        return $"{url}:{port}/now";
    }

    private static async Task<(long Milliseconds, string? Result, int StatusCode)> GetAsync(string url, CancellationToken cancellationToken)
    {
        using var client = new HttpClient();
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        var response = await client.GetAsync(url, cancellationToken);
        stopwatch.Stop();

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        return (stopwatch.ElapsedMilliseconds, content, (int)response.StatusCode);
    }
}