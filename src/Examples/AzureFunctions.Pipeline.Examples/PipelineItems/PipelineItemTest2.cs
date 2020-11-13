using AzureFunctions.Pipeline.Abstractions;
using AzureFunctions.Pipeline.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AzureFunctions.Pipeline.Examples.PipelineItems
{
    internal sealed class PipelineItemTest2 : IPipelineItem
    {
        public IPipelineContext PipelineContext { get; }

        public PipelineItemTest2(IPipelineContext pipelineContext)
        {
            PipelineContext = pipelineContext;
        }

        public Task ExecuteAsync()
        {
            var req = PipelineContext.HttpContextAccessor.HttpContext.Request;

            if (!req.Query.ContainsKey("smile"))
                throw new PipelineExecutionException(new BadRequestResult());

            return Task.CompletedTask;
        }
    }
}