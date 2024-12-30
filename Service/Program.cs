using Microsoft.AspNetCore.Diagnostics.HealthChecks;

using Service.Library.Health;


var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
var (url, port) = ParseConfiguration(builder.Configuration);

builder.WebHost.UseUrls($"{url}:{port}");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHealthChecks()
    .AddCheck<NowServiceHealthCheck>(nameof(NowServiceHealthCheck), tags: new[] { $"url={url}", $"port={port}" });

var app = builder.Build();
app.UseHttpsRedirection();
app.MapHealthChecks("/", new HealthCheckOptions
{
    ResponseWriter = CustomWriter.WriteResponse
});
MapCustomEndpoints(app);
app.Run();

static (string Url, int port) ParseConfiguration(IConfiguration configuration)
{
    var url = configuration.GetValue<string>("Kestrel:Urls");
    if (url is null)
    {
        throw new InvalidOperationException("Kestrel:Urls is not configured");
    }
    var uri = new Uri(url);
    return ($"{uri.Scheme}://{uri.Host}", uri.Port);
}

static void MapCustomEndpoints(WebApplication app)
{
    app.MapGet("/now", Service.Library.Endpoints.GetNow);
}

