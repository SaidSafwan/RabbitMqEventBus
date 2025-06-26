using System;
using System.Threading.Tasks;
using App2.Entities.Samples;
using App2.Samples;
using Volo.Abp.Domain.Repositories;

namespace App2.Services
{
    public class SampleService
    : ISampleService
    {
        private readonly IRepository<Sample, Guid> _sampleRepository;

        public SampleService(
            IRepository<Sample, Guid> sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }

        public async Task<SampleDto> CreateAsync(SampleDto sampleDto)
        {
            var sample = new Sample()
            {
                Name = sampleDto.Name
            };
            var result = await _sampleRepository.InsertAsync(sample);
            return new SampleDto
            {
                Id = result.Id,
                Name = result.Name,
            };
        }

        //public async Task<SampleDto> GetByIdAsync(Guid id)
        //{
        //    var result = await _sampleRepository.FirstOrDefaultAsync(x => x.Id == id);
        //    return ObjectMapper.Map<Sample, SampleDto>(result);
        //}

        //public async Task<List<SampleDto>> GetAllAsync()
        //{
        //    var result = await _sampleRepository.GetListAsync();
        //    return ObjectMapper.Map<List<Sample>, List<SampleDto>>(result);
        //}
    }
}
