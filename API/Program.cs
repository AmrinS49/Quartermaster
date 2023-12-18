using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt =>
{
    // TODO : Add safety if any of these are null
    
    string host = Environment.GetEnvironmentVariable("DB_HOST");
    string port = Environment.GetEnvironmentVariable("DB_PORT");
    string database = Environment.GetEnvironmentVariable("DB_DATABASE");
    string username = Environment.GetEnvironmentVariable("DB_USERNAME");
    string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
    
    string connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";

    opt.UseNpgsql(connectionString);
});

builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policy => {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();


using var scope = app.Services.CreateScope();
var services =  scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.SeedData(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred during migration");
}


app.Run();
