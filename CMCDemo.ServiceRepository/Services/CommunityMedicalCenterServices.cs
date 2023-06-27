using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;

namespace CMCDemo.ServiceRepository.Services
{
    internal class CommunityMedicalCenterServices : ICommunityMedicalCenterService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CommunityMedicalCenterServices(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<Community_Medical_CentersDto> CreateCMCDto(Community_Medical_CentersForCreation creationDto)
        {
            var MapCmcAddress = _mapper.Map<MedicalCenterAddress>(creationDto.MedicalCenterAddress);
            _repository.MedicalCenterAddress.CreateMedicalCenterAddress(MapCmcAddress);
            await _repository.SaveAsync();
            creationDto.MedicalCenterAddressId = MapCmcAddress.Id;
            var MapCMC = _mapper.Map<Community_Medical_Centers>(creationDto);
            _repository.Community_Medical_Centers.CreateCommunity_Medical_Centers(MapCMC);
            await _repository.SaveAsync();
            return _mapper.Map<Community_Medical_CentersDto>(MapCMC);
        }

        public async Task DeleteCMCDto(int Id, bool trackChanges)
        {
            var GetCMC = await _repository.Community_Medical_Centers.GetCommunity_Medical_CenterById(Id, trackChanges);
            _repository.Community_Medical_Centers.DeleteCommunity_Medical_Centers(GetCMC);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Community_Medical_CentersDto>> GetAllCMCDtoAsync(bool trackChanges)
        {
            try
            {
                var GetCMC = await _repository.Community_Medical_Centers.GetAllCommunity_Medical_CenterAsync(trackChanges);
                var MapCMC = _mapper.Map<IEnumerable<Community_Medical_CentersDto>>(GetCMC);
                return MapCMC;
            }
            catch (Exception ex)
            {
                _logger.LogError($"There was an error calling name of {GetAllCMCDtoAsync}. Error {ex}");
                throw;
            }
        }

        public async Task<Community_Medical_CentersDto> GetCMCDtoAsync(int Id, bool trackChanges)
        {
            try
            {
                var GetCMC = await _repository.Community_Medical_Centers.GetCommunity_Medical_CenterById(Id, trackChanges);
                var MapCMC = _mapper.Map<Community_Medical_CentersDto>(GetCMC);
                return MapCMC;
            }
            catch (Exception ex)
            {
                _logger.LogError($"There was an error loading {GetCMCDtoAsync}. Error {ex}");
                throw;
            }
        }

        public async Task<Community_Medical_CentersDto> UpdateCMCDto(int Id, Community_Medical_CentersForUpdate community_Medical_CentersForUpdate, bool trackChanges)
        {
            var GetCMC = await _repository.Community_Medical_Centers.GetCommunity_Medical_CenterById(Id, trackChanges);
            var MapCMC = _mapper.Map(community_Medical_CentersForUpdate, GetCMC);
            _repository.Community_Medical_Centers.UpdateCommunity_Medical_Centers(MapCMC);
            await _repository.SaveAsync();
            return _mapper.Map<Community_Medical_CentersDto>(MapCMC);
        }
    }
}