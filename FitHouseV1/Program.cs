using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using REPOSITORY;
using REPOSITORY.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnetion"));
});

//Inyeccion de dependencia para cualquier modelo del repository
builder.Services.AddTransient(typeof(IGeneryicRepository<>), typeof(RepoGeneric<>));

builder.Services.AddScoped<IProducto,RepoProducto>();

//builder.Services.AddAutoMapper(typeof());


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
