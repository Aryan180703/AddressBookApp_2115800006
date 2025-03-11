using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AddressBookDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection")));

var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
