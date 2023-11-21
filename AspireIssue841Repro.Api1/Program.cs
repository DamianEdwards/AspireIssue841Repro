var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.MapGet("/api1", async () =>
{
    await Task.Delay(100);
    return 1;
});

app.MapGet("/api2", async () =>
{
    await Task.Delay(100);
    return 2;
});

app.MapGet("/api3", async () =>
{
    await Task.Delay(100);
    return 3;
});

app.MapGet("/api4", async () =>
{
    await Task.Delay(100);
    return 4;
});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
