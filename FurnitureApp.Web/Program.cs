using FurnitureApp.Services;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//Views
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Add services
builder.Services.AddPersistenceServices();
builder.Services.AddTransient<ITempDataProvider, TempDataProvider>();
builder.Services.AddTransient<ITempDataDictionaryFactory, TempDataDictionaryFactory>();

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

public class TempDataProvider: ITempDataProvider
{
    public IDictionary<string, object> LoadTempData(HttpContext context)
    {
        throw new NotImplementedException();
    }

    public void SaveTempData(HttpContext context, IDictionary<string, object> values)
    {
        throw new NotImplementedException();
    }
}
