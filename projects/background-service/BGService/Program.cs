using BGService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<CleanerService>();

IHost host = builder.Build();
host.RunAsync(); // By not having the await keyword, the program will not wait for the host to finish running before continuing to the next line of code.
while (true)
{
    Console.Write("#");
    Thread.Sleep(1000);
}