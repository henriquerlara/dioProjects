using Microsoft.EntityFrameworkCore;
using API;
using DotNetEnv;

Env.Load(); // load environment variables from .env file (in this project, "ConnectionStrings__DefaultConnection" for the local database connection)

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EmployeeContext>(options =>
{
    var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("The connection string 'DefaultConnection' was not found or is empty.");
    }

    options.UseNpgsql(connectionString, o =>
    {
        o.MigrationsHistoryTable("__EFMigrationsHistory", "hr_system");
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<EmployeeContext>();
    dbContext.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
