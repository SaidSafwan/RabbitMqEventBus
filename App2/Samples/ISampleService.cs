using System.Threading.Tasks;

namespace App2.Samples
{
    public interface ISampleService
    {
        Task<SampleDto> CreateAsync(SampleDto sampleDto);
        //Task<SampleDto> GetByIdAsync(Guid id);
        //Task<List<SampleDto>> GetAllAsync();
    }
}
