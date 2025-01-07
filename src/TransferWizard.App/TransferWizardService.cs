using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace TransferWizard.App
{
   public class TransferWizardService : IHostedService
   {
      public ILogger<TransferWizardService> _logger; 
      public IHostApplicationLifetime _applicationLifetime;

      public TransferWizardService(IHostApplicationLifetime applicationLifetime, ILogger<TransferWizardService> logger)
      {
         _applicationLifetime = applicationLifetime;
         _logger = logger;
      }
      
      public Task StartAsync(CancellationToken cancellationToken)
      {
         _logger.LogInformation("Hello World!");


         // Import or manually map classes between coolleges
         
         // Import or manually enter classes for the current next plan of study 
         
         // Import or manually enter classes for the next plan of study
          
         _applicationLifetime.StopApplication();
         return Task.CompletedTask;
      }

      public Task StopAsync(CancellationToken cancellationToken)
      {
         _logger.LogInformation("The End");
         return Task.CompletedTask;
      }
   }
}
