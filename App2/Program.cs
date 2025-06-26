using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace App2
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            using (var application = AbpApplicationFactory.Create<App2Module>(options =>
            {
                options.UseAutofac();
                options.Services.AddLogging(config =>
                {
                    config.AddConsole(); // Enable console logging for debugging
                });
            }))
            {
                try
                {
                    application.Initialize();

                    var messagingService = application
                        .ServiceProvider
                        .GetRequiredService<App2MessagingService>();

                    await messagingService.RunAsync();

                    application.Shutdown();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Application initialization failed: {ex.Message}");
                    Console.WriteLine($"StackTrace: {ex.StackTrace}");
                    throw;
                }
            }
        }
    }
}
