using Microsoft.EntityFrameworkCore;
using Stage.API.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(
        options => options.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AnimaFest;Data Source=THIAGOYURI;User Id=sa;Password=admin123;TrustServerCertificate=True"));
builder.Services.AddControllers();

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
