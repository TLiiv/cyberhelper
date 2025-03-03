using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using server.Data.Migrations;
using server.Data;
using server.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowClient",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IEmailsService, EmailsService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=phishingTest.db")
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AllowClient");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


using (var scope = app.Services.CreateScope())

using (var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
{
    context.Database.EnsureCreated();
    SeedData.Generate(context);
}

app.Run();
