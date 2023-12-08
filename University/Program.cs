using DbUp;
using Npgsql;
using System.Data;
using System.Reflection;
using University.Interfaces;
using University.Repositories;
using University.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IStudentasRepository, StudentasRepository>();
builder.Services.AddTransient<IDepartamentasRepository, DepartamentasRepository>();
builder.Services.AddTransient<IPaskaitaRepository, PaskaitaRepository>();
builder.Services.AddTransient<IStudentasService, StudentasService>();
builder.Services.AddTransient<IDepartamentasService, DepartamentasService>();
builder.Services.AddTransient<IPaskaitaService, PaskaitaService>();

string dbConnectionString = builder.Configuration.GetConnectionString("PostgreConnection");
builder.Services.AddTransient<IDbConnection>(sp => new NpgsqlConnection(dbConnectionString));

var upgrader =
    DeployChanges.To
        .PostgresqlDatabase(dbConnectionString)
        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
        .LogToConsole()
        .Build();

var result = upgrader.PerformUpgrade();

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
