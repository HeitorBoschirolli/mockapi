var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/api", (HttpRequest request) =>
{
    var rnd = new Random();
    var isCached = rnd.Next(1, 3) == 2;
    return new ResponseDto(request.Query["id"], isCached);
});

app.Run();

internal record ResponseDto(string Id, bool IsCached)
{
}