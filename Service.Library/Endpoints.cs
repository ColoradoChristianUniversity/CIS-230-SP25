using Microsoft.AspNetCore.Http;

namespace Service.Library;

public class Endpoints
{
    public static string GetNow(HttpContext context)
    {
        return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
}
