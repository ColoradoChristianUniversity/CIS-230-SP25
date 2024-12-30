using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;

using Service.Library.Health;

var url = "http://localhost";
var port = "1234";

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls($"{url}:{port}");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks()
    .AddCheck<NowServiceHealthCheck>(nameof(NowServiceHealthCheck), tags: new[] { $"url={url}", $"port={port}" });

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}
app.UseHttpsRedirection();
app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = CustomWriter.WriteResponse
});
MapCustomEndpoints(app);
app.Run();

static void MapCustomEndpoints(WebApplication app)
{
    app.MapGet("/now", Service.Library.Endpoints.GetNow);
}

