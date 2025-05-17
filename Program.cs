using FactoryPatternDemo.Factory;
using FactoryPatternDemo.Interfaces;
using FactoryPatternDemo.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<EmailNotification>();
builder.Services.AddTransient<SMSNotification>();
builder.Services.AddTransient< WhastsAppNotification>();
builder.Services.AddTransient<NotificationFactory>();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Factory Pattern Demo API",
        Version = "v1",
        Description = "An API for demonstrating Factory Pattern"
    });
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Factory Pattern Demo API v1");
    options.RoutePrefix = string.Empty;  // Makes Swagger UI launch at root URL
});
app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();
