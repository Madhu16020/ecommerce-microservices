var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Gaming Laptop" },
        new { Id = 2, Name = "Phone" }
    };
});

app.Run();
