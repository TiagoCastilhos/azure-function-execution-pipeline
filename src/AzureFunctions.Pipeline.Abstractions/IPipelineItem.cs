using System.Threading.Tasks;

namespace AzureFunctions.Pipeline.Abstractions
{
    public interface IPipelineItem
    {
        IPipelineContext PipelineContext { get; }

        Task ExecuteAsync();
    }
}