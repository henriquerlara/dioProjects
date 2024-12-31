using Microsoft.EntityFrameworkCore;
using API;
using DotNetEnv;

Env.Load(); // carregar as variáveis de ambiente do .env (no caso desse projeto, "ConnectionStrings__ConexaoPadrao" para conexãocom o banco local)

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TarefaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
