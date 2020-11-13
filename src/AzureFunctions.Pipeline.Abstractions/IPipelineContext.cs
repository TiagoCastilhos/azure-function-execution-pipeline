using Microsoft.AspNetCore.Http;

namespace AzureFunctions.Pipeline.Abstractions
{
    public interface IPipelineContext
    {
        IHttpContextAccessor HttpContextAccessor { get; }
    }
}