using Microsoft.EntityFrameworkCore;
using Stage.API.DAL;
using System.Configuration;
using System;
using Stage.API.Web.Services;
using Microsoft.OpenApi.Models;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*")
                          .AllowAnyHeader()
                          .AllowAnyOrigin()
                          .AllowAnyMethod();
                          
                      });
});

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<Context>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration["Stage:ConnectionString"]));
builder.Services.AddScoped<AreaServices, AreaServices>();
builder.Services.AddScoped<ProcessoServices, ProcessoServices>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
