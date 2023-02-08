using ELK.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

using static System.Net.Mime.MediaTypeNames;

var builder = Host.CreateDefaultBuilder();

builder.ConfigureHostConfiguration(x => {
    x.AddJsonFile("appsettings.json");
});

builder.ConfigureServices(config => {
    config.AddSingleton<Test>();
});

builder.UseSerilog((host, service, config) =>
{
    config.ReadFrom.Configuration(host.Configuration);
});
var app = builder.Build();

var test = app.Services.GetRequiredService<Test>();

test.TestMethod();

app.Run();


