using FinallyProject;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql("name=ConnectionStrings:DefaultConnection"));
builder.Services.AddSwaggerGen();
//builder.Services.AddSpaStaticFiles();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}


app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";
    if (app.Environment.IsDevelopment())
    {
        spa.UseAngularCliServer(npmScript: "start");
        //spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
    }
});
app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

app.UseHttpsRedirection();

app.UseDefaultFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();