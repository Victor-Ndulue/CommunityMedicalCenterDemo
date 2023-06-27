using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;

namespace CMCDemo.ServiceRepository.Services
{
    internal class Ref_DisciplinesService : IRef_DisciplinesService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public Ref_DisciplinesService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<Ref_DisciplinesDto> CreateRef_Disciplines(Ref_DisciplinesForCreation creationDto)
        {
            var MapRef = _mapper.Map<Ref_Disciplines>(creationDto);
            _repository.Ref_Disciplines.CreateRef_Disciplines(MapRef);
            await _repository.SaveAsync();
            return _mapper.Map<Ref_DisciplinesDto>(MapRef);
        }

        public async Task DeleteRef_DisciplinesAsync(int Id, bool trackChanges)
        {
            var GetRef = await _repository.Ref_Disciplines.GetRef_DisciplinesById(Id, trackChanges);
            _repository.Ref_Disciplines.DeleteRef_Disciplines(GetRef);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Ref_DisciplinesDto>> GetAllDisciplinesAsync(bool trackChanges)
        {
            var GetRef = await _repository.Ref_Disciplines.GetAllRef_DisciplinesAsync(trackChanges);
            var MapRef = _mapper.Map<IEnumerable<Ref_DisciplinesDto>>(GetRef);
            return MapRef;

        }

        public async Task<Ref_DisciplinesDto> GetDisciplinesAsync(int Id, bool trackChanges)
        {
            var GetRef = await _repository.Ref_Disciplines.GetRef_DisciplinesById(Id, trackChanges);
            var MapRef = _mapper.Map<Ref_DisciplinesDto>(GetRef);
            return MapRef;
        }

        public async Task<Ref_DisciplinesDto> UpdateRef_Disciplines(int Id, Ref_DisciplinesForUpdate updatedDto, bool trackChanges)
        {
            var GetRef = await _repository.Ref_Disciplines.GetRef_DisciplinesById(Id, trackChanges);
            var MapRef = _mapper.Map(updatedDto, GetRef);
            _repository.Ref_Disciplines.UpdateRef_Disciplines(MapRef);
            await _repository.SaveAsync();
            return _mapper.Map<Ref_DisciplinesDto>(MapRef);
        }
    }
}
