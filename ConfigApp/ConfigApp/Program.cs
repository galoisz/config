using ConfigApp;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder().AddJsonFile($"appsettings.json");

var config = configuration.Build();

//var x = config.Get<custSettings>();
var x = new custSettings();

IConfigurationSection section = config.GetSection("Settings");

section.Bind(x);

Console.WriteLine(section.Value);



// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
