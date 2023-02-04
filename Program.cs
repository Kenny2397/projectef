using projectef;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TasksContext>(p => p.UseInMemoryDatabase("TasksDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async ([FromServices] TasksContext dbcontext) => {
  dbcontext.Database.EnsureCreated();
  return Results.Ok("Database connection: " + dbcontext.Database.IsInMemory());
} );  

app.Run();
