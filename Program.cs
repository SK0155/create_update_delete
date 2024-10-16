using Crud.Data.Repository;
using Crud.Data.Services;
using Crud.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var service = builder.Services;
service.AddDbContext<DataBaseContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"),item=>item.MigrationsAssembly("Crud")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
        builder.SetIsOriginAllowed(_ => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
service.AddScoped<IStudentService, StudentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();
