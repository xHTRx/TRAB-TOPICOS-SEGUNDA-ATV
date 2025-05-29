//src/Program.cs
using Microsoft.EntityFrameworkCore;
using src.Context; // namespace onde está o PetContext
using API_AdocaoPets.src.Models;  // se necessário para inicialização
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using API_AdocaoPets.src;

var builder = WebApplication.CreateBuilder(args);

// Configurar o serviço do Entity Framework Core com SQLite
builder.Services.AddDbContext<PetContext>(options =>
    options.UseSqlite("Data Source=Bd_sql/adocao.db")); // caminho relativo à pasta Bd_sql

// Adicionar suporte a controllers
builder.Services.AddControllers();

// Adicionar suporte para Swagger (opcional, mas útil para testes de rotas)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware para documentar a API via Swagger (ambiente de dev)
// if (app.Environment.IsDevelopment())

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

// Middleware de roteamento de endpoints
app.UseAuthorization();
app.MapControllers();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PetContext>();
    DbInitializer.Initialize(db);
}

app.Run();