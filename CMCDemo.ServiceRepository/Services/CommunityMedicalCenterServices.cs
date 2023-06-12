using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s;
using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var MapCMC = _mapper.Map<Community_Medical_Centers>(creationDto);
            _repository.Community_Medical_Centers.CreateCommunity_Medical_Centers(MapCMC);
            await _repository.SaveAsync();
            return _mapper.Map<Community_Medical_CentersDto>(MapCMC);
        }

        public async Task DeleteCMCDto(string Name, bool trackChanges)
        {
            var GetCMC = await _repository.Community_Medical_Centers.GetCommunity_Medical_CenterByName(Name, trackChanges);
            _repository.Community_Medical_Centers.DeleteCommunity_Medical_Centers(GetCMC);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<Community_Medical_CentersDto>> GetAllCMCDtoAsync(bool trackChanges)
        {
            var GetCMC = await _repository.Community_Medical_Centers.GetAllCommunity_Medical_CenterAsync(trackChanges);
            var MapCMC = _mapper.Map<IEnumerable<Community_Medical_CentersDto>>(GetCMC);
            return MapCMC;
        }

        public async Task<Community_Medical_CentersDto> GetCMCDtoAsync(string Name, bool trackChanges)
        {
            var GetCMC = await _repository.Community_Medical_Centers.GetCommunity_Medical_CenterByName(Name, trackChanges);
            var MapCMC = _mapper.Map<Community_Medical_CentersDto>(GetCMC);
            return MapCMC;
        }

        public async Task <Community_Medical_CentersDto> UpdateCMCDto(string Name, Community_Medical_CentersForUpdate community_Medical_CentersForUpdate, bool trackChanges)
        {
            var GetCMC = await _repository.Community_Medical_Centers.GetCommunity_Medical_CenterByName(Name, trackChanges);
            var MapCMC = _mapper.Map(community_Medical_CentersForUpdate, GetCMC);
            _repository.Community_Medical_Centers.UpdateCommunity_Medical_Centers(MapCMC);
            await _repository.SaveAsync();
            return _mapper.Map<Community_Medical_CentersDto>(MapCMC);
        }
    }
}