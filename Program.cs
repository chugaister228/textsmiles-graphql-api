using Microsoft.EntityFrameworkCore;
using TextSmiles.API.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=textsmiles.db")
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();