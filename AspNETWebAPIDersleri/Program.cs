using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Cors Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", buil =>
    {
        buil.AllowAnyOrigin().WithMethods().AllowAnyHeader();
    });
});


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
app.UseCors("AllowAll");

app.Run();


// Servisleri ekle
builder.Services.AddControllers();
// Middleware'leri ekle
app.UseRouting();
app.UseAuthorization();

// Test endpoint
app.MapGet("/", () => "API çalýþýyor!");

// Controller endpoint'leri
app.MapControllers();
app.UseStaticFiles();


app.Run();
