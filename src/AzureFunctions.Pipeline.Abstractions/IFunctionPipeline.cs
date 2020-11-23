using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AzureFunctions.Pipeline.Abstractions
{
    public interface IFunctionPipeline
    {
        IEnumerable<IPipelineItem> Items { get; }

        Task<IActionResult> ExecuteAsync(Func<Task<IActionResult>> action, CancellationToken cancellationToken = default);
    }
}