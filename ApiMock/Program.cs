var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/api", (HttpRequest request) =>
{
    return new ResponseDto(request.Query["id"]);
});

app.Run();

internal record ResponseDto(string Id)
{
}