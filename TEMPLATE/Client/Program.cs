using Client.Library;

await Task.Delay(5000); 

var nowEndpoint = new NowEndpoint("http://localhost:1234");
var nowValue = nowEndpoint.Get();

Console.WriteLine($"Received: {nowValue}");
Console.Read();