namespace Client.Library;

public class NowEndpoint(string baseUrl, HttpClient? httpClient = null)
{
    public string Get()
    {
        var http = httpClient ?? new();
        var uri = new Uri(new Uri(baseUrl), "/now");
        return http.GetStringAsync(uri).Result;
    }
}
