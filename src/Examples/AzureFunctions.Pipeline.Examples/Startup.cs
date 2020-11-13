using AzureFunctions.Pipeline.Abstractions;
using AzureFunctions.Pipeline.Examples.PipelineItems;
using AzureFunctions.Pipeline.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunctions.Pipeline.Examples.Startup))]
namespace AzureFunctions.Pipeline.Examples
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddPipeline();
            builder.Services.AddScoped<IPipelineItem, PipelineItemTest>();
            builder.Services.AddScoped<IPipelineItem, PipelineItemTest2>();
        }
    }
}