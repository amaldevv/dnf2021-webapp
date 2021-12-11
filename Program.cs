var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"Hello World!, App is running from {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");

app.Run();
