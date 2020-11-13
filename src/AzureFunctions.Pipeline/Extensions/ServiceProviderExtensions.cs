using AzureFunctions.Pipeline.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctions.Pipeline.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static IServiceCollection AddPipeline(this IServiceCollection services)
        {
            services.AddScoped<IPipelineContext, PipelineContext>();
            services.AddScoped<IFunctionPipeline, FunctionPipeline>();

            return services;
        }
    }
}