using Microsoft.EntityFrameworkCore;
using WebAPIPersona.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// create varible string for connection
var connectionString = builder.Configuration.GetSection("ConnectionString")["WebApiDatabase"];
// register service for the connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));
 
builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
