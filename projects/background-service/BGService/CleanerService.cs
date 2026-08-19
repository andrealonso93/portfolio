using Microsoft.Extensions.Hosting;

namespace BGService;

public class CleanerService : BackgroundService
{

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Thread.Sleep(10000);
            Console.WriteLine("Adding new line");
        }
    }
}