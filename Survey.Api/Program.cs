using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Survey.Contract.Requests.RequestsValidations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPollServices, PollServices>();

builder.Services
    .AddFluentValidationAutoValidation()
    .AddValidatorsFromAssembly(typeof(CreatePollRequestValidation).Assembly);



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