using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using MySql.EntityFrameworkCore.Extensions;
using Pill_eHealth.Entities;
using System.Configuration;

var conf = (JsonConfigurationExtensions.AddJsonFile(new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()), "appsettings.json").Build());
var PillAllowSpecificOrigins = conf["CORS:AllowOrigins"];
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://pillehealthdev-001-site1.htempurl.com");
        });
    //options.AddPolicy(name: "AllowHeaders",
    //        policy =>
    //        {
    //            policy.WithOrigins(PillAllowSpecificOrigins)
    //            .WithHeaders(HeaderNames.ContentType, HeaderNames.Server, HeaderNames.AccessControlAllowHeaders, HeaderNames.AccessControlExposeHeaders, "x-custom-header", "x-path", "x-record-in-use", HeaderNames.ContentDisposition);
    //        }
    //    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkMySQL()
    .AddDbContext<ThepillcPillEhealthContext>(options =>
    {
        options.UseMySQL(builder.Configuration.GetConnectionString("ProdDB"));
    });

var app = builder.Build();

//app.UseCors("CORSPolicy");
app.UseCors();

app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
