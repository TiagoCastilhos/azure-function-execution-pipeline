using AzureFunctions.Pipeline.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace AzureFunctions.Pipeline.Examples
{
    public class TestFunctions
    {
        private readonly IFunctionPipeline _functionPipeline;

        public TestFunctions(IFunctionPipeline functionPipeline)
        {
            _functionPipeline = functionPipeline;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] 
            HttpRequest req)
        {
            return await _functionPipeline.ExecuteAsync(() => new OkResult());
        }
    }
}