var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var inMemoryData = new Dictionary<int, string>(); 

app.MapGet("/all", () =>
{
    return System.Text.Json.JsonSerializer.Serialize(inMemoryData);
});

app.MapGet("/get/{id:int}", (int id) =>
{
    if (inMemoryData.TryGetValue(id, out var value))
    {
        return Results.Ok(value);
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapPost("/add/{value}", (string value) =>
{
    inMemoryData[inMemoryData.Count + 1] = value;
    return Results.Ok();
});

app.MapPut("/update/{id:int}/{value}", (int id, string value) =>
{
    if (inMemoryData.ContainsKey(id))
    {
        inMemoryData[id] = value;
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapDelete("/delete/{id:int}", (int id) =>
{
    if (inMemoryData.Remove(id))
    {
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
