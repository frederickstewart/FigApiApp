using FigApiApp.Models;

using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<PlayerContext>(opt => opt.UseInMemoryDatabase("PlayerList"));
builder.Services.AddDbContext<TeamContext>(opt => opt.UseInMemoryDatabase("TeamList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
   //app.UseSwagger();
   //app.UseSwaggerUI();
   app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();