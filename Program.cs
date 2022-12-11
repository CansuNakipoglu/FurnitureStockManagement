using FurnitureStockManagement.Data;
using FurnitureStockManagement.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using FurnitureStockManagement.Repositories.Interfaces;
using FurnitureStockManagement.Services.Interfaces;
using FurnitureStockManagement.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(@"Data Source=LAPTOP-U6OAPOKL\SQLEXPRESS;Initial Catalog=FurnitureStockManagement;Integrated Security=True;TrustServerCertificate=True");
});
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped<IStockService, StockService>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
