using AzureFunctions.Pipeline.Abstractions;
using AzureFunctions.Pipeline.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AzureFunctions.Pipeline
{
    internal sealed class FunctionPipeline : IFunctionPipeline
    {
        public IEnumerable<IPipelineItem> Items { get; }

        public FunctionPipeline(IEnumerable<IPipelineItem> items)
        {
            Items = items;
        }

        public async Task<IActionResult> ExecuteAsync(Func<Task<IActionResult>> action, CancellationToken cancellationToken = default)
        {
            try
            {
                foreach (var item in Items)
                    await item.ExecuteAsync().ConfigureAwait(false);

                return await Task.Run(action, cancellationToken).ConfigureAwait(false);
            }
            catch (PipelineExecutionException e)
            {
                return e.Result;
            }
        }
    }
}