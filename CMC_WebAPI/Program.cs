using CMC_WebAPI.Extensions;
using NLog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Adding path to our NLogger Service.
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nLog.Config"));
//Calling our defined method for Logging Services
builder.Services.ConfigureLoggerService();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
