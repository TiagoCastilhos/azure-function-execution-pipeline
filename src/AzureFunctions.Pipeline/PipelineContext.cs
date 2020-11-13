using AzureFunctions.Pipeline.Abstractions;
using Microsoft.AspNetCore.Http;

namespace AzureFunctions.Pipeline
{
    internal sealed class PipelineContext : IPipelineContext
    {
        public IHttpContextAccessor HttpContextAccessor { get; }

        public PipelineContext(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
    }
}