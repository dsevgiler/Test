using Microsoft.EntityFrameworkCore;
using Test.Context;

var builder = WebApplication.CreateBuilder(args);

var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DnzContext>(options =>
{
    options.UseMySql("Data Source = localhost; port = 3306; uid=root;pwd=3105; Persist Security Info = True; Initial Catalog = test", serverVersion);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
