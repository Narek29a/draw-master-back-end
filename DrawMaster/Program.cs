using DrawMaster.Rectangle.Data;
using DrawMaster.Rectangle.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IRectangleService, RectangleService>();
builder.Services.AddSingleton<IRectangleDao, RectangleDao>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builderCors =>
    {
        builderCors
            .WithOrigins("http://localhost:4200")
            .AllowCredentials()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();                 
}
app.MapControllers();
app.UseCors("AllowSpecificOrigin");

app.Run();
