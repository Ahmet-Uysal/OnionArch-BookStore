using System.Text.Json.Serialization;
using BookStore.Api.Extensions;
using BookStore.Application;
using BookStore.Application.Validations;
using BookStore.Infrastructure;
using BookStore.Infrastructure.Filters;
using BookStore.Persistence;
using FluentValidation.AspNetCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(opt => opt.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<AddCategoryValidator>())
        .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true).AddJsonOptions(option =>
           option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddInfrastructureServices();
builder.Services.AddApplicationServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
