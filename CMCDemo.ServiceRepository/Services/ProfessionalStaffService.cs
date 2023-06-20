using AutoMapper;
using CMCDemo.Applications.Common;
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
    internal class ProfessionalStaffService : IProfessionalStaffService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ProfessionalStaffService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProfessionalStaffDto> CreateProfessionalStaffDto(ProfessionalStaffForCreation CreationDto)
        {
            var ProfessionalStaffMapped = _mapper.Map<ProfessionalStaff>(CreationDto);
            _repository.ProfessionalStaff.CreateProfessionalStaff(ProfessionalStaffMapped);
            await _repository.SaveAsync();
            return _mapper.Map<ProfessionalStaffDto>(ProfessionalStaffMapped);
        }

        public async Task DeleteProfessionalStaffAsync(int Id, bool trackChanges)
        {
            var GetProfessionalStaff = await _repository.ProfessionalStaff.GetProfessionalStaffById(Id, trackChanges);
            _repository.ProfessionalStaff.DeleteProfessionalStaff(GetProfessionalStaff);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProfessionalStaffDto>> GetAllProfessionalStaffDtoAsync(bool trackChanges)
        {
            var GetProfessionalStaffs = await _repository.ProfessionalStaff.GetAllProfessionalStaffAsync(trackChanges);
            var MapProfessionalStaffs = _mapper.Map<IEnumerable<ProfessionalStaffDto>>(GetProfessionalStaffs);
            return MapProfessionalStaffs;
        }

        public async Task<ProfessionalStaffDto> GetProfessionalStaffDtoAsync(int Id, bool trackChanges)
        {
            var GetProfessionalstaff = await _repository.ProfessionalStaff.GetProfessionalStaffById(Id, trackChanges);
            var MapProfessionalStaff = _mapper.Map<ProfessionalStaffDto>(GetProfessionalstaff);
            return MapProfessionalStaff;
        }

        public async Task <ProfessionalStaffDto> UpdateProfessionalStaffAsync(int Id, ProfessionalStaffForUpdate professsionalStaffForUpdate, bool trackChanges)
        {
            var GetProfessionalStaff = await _repository.ProfessionalStaff.GetProfessionalStaffById(Id, trackChanges);
            var mapPStaff = _mapper.Map(professsionalStaffForUpdate, GetProfessionalStaff);
            _repository.ProfessionalStaff.UpdateProfessionalStaff(mapPStaff);
            await _repository.SaveAsync();
            return _mapper.Map<ProfessionalStaffDto>(mapPStaff);
        }
    }
}
