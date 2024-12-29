using BooksApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Retrieve connection string from configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Check if the connection string is null and throw an exception if so
if (connectionString is null)
{
    throw new InvalidOperationException("Connection string is missing in configuration.");
}

// Add services to the container, including DbContext with the connection string
builder.Services.AddDbContext<BooksContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
