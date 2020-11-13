using AzureFunctions.Pipeline.Abstractions;
using AzureFunctions.Pipeline.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AzureFunctions.Pipeline.Examples.PipelineItems
{
    internal sealed class PipelineItemTest : IPipelineItem
    {
        public IPipelineContext PipelineContext { get; }

        public PipelineItemTest(IPipelineContext pipelineContext)
        {
            PipelineContext = pipelineContext;
        }

        public Task ExecuteAsync()
        {
            var req = PipelineContext.HttpContextAccessor.HttpContext.Request;

            if (!req.Headers.ContainsKey("Authorization"))
                throw new PipelineExecutionException(new UnauthorizedResult());

            return Task.CompletedTask;
        }
    }
}