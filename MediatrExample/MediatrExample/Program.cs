using Cqrs.Hosts;
using MediatR;
using MediatrExample.Med.Queries;
using Microsoft.AspNetCore.Hosting;
using static MediatrExample.Med.Queries.GettAllProductQuery;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(StartUp));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(StartUp));
builder.Services.AddTransient<IRequestHandler<GettAllProductQuery, List<GetProductViewModel>>, GettAllProductQueryHandler>();
builder.Services.AddScoped<IRequestHandler<GetProductByIdQuery, GetProductViewModel>, GetProductByIdQuaryHandler>();
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
