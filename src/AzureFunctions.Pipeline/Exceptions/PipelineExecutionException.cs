using Microsoft.AspNetCore.Mvc;
using System;

namespace AzureFunctions.Pipeline.Exceptions
{
    public class PipelineExecutionException : Exception
    {
        public IActionResult Result { get; }

        public PipelineExecutionException(IActionResult result)
        {
            Result = result;
        }
    }
}