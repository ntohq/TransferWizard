using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace TransferWizard.App
{  
   class Program
   {
      public static IHostBuilder CreateHostBuilder()
      {
         return Host.CreateDefaultBuilder()
            .ConfigureServices(services => services.AddHostedService<TransferWizardService>())
            .ConfigureLogging(config => config.AddConsole());
      }

      public static void Main(string[] args)
      {
         var host = CreateHostBuilder().Build();
         host.Run();
      }
   }
}
