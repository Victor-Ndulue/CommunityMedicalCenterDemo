using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s.StaffAddressDTOS;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceRepository.Services
{
    internal class StaffAddressService : IStaffAddressService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public StaffAddressService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<StaffAddressDto> CreateStaffAddress(StaffAddressForCreation creationDto)
        {
            var MapStA = _mapper.Map<StaffAddress>(creationDto);
            _repository.StaffAddress.CreateStaffAddress(MapStA);
            await _repository.SaveAsync();
            return _mapper.Map<StaffAddressDto>(MapStA);
        }

        public async Task DeleteStaffAddressAsync(string Name, bool trackChanges)
        {
            var GetStA = await _repository.StaffAddress.GetStaffAddressByName(Name, trackChanges);
            _repository.StaffAddress.DeleteStaffAddress(GetStA);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<StaffAddressDto>> GetAllStaffAddressDtoAsync(bool trackChanges)
        {
            var GetStA = await _repository.StaffAddress.GetAllStaffAddressAsync(trackChanges);
            var MapStA = _mapper.Map<IEnumerable<StaffAddressDto>>(GetStA);
            return MapStA;
        }

        public async Task<StaffAddressDto> GetStaffAddressDtoAsync(string Name, bool trackChanges)
        {
            var GetStA = await _repository.StaffAddress.GetStaffAddressByName(Name, trackChanges);
            var MapStA = _mapper.Map<StaffAddressDto>(GetStA);
            return MapStA;
        }

        public async Task<StaffAddressDto> UpdateStaffAddress(string Name, StaffAddressForUpdate staffAddressForUpdate, bool trackChanges)
        {
            var GetStA = await _repository.StaffAddress.GetStaffAddressByName(Name, trackChanges);
            var MapStA = _mapper.Map(staffAddressForUpdate, GetStA);
            await _repository.SaveAsync();
            return _mapper.Map<StaffAddressDto>(MapStA);
        }
    }
}
