using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceRepository.Services
{
    internal class MedicalCenterAddressService : IMedicalCenterAddressService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public MedicalCenterAddressService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<MedicalCenterAddressDto> CreateMedicalCenterAddress(MedicalCenterAddressForCreation creationDto) 
        { 
            var MapMCD = _mapper.Map<MedicalCenterAddress>(creationDto);
            _repository.MedicalCenterAddress.CreateMedicalCenterAddress(MapMCD);
            await _repository.SaveAsync();
            return _mapper.Map<MedicalCenterAddressDto>(MapMCD);
        }

        public async Task DeleteMedicalCenterAddress(string Name, bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetMedicalCenterAddressByName(Name, trackChanges);
            _repository.MedicalCenterAddress.DeleteMedicalCenterAddress(GetMCD);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<MedicalCenterAddressDto>> GetAllMedicalCenterAddress(bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetAllMedicalCenterAddressesAsync(trackChanges);
            var MapMCD = _mapper.Map<IEnumerable<MedicalCenterAddressDto>>(GetMCD);
            return MapMCD;
        }

        public async Task<MedicalCenterAddressDto> GetMedicalCenterAddressByName(string Name, bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetMedicalCenterAddressByName(Name, trackChanges);
            var MapMCD = _mapper.Map<MedicalCenterAddressDto>(GetMCD);
            return MapMCD;
        }

        public async Task<MedicalCenterAddressDto> UpdateMedicalCenterAddress(string Name, MedicalCenterAddressDto Address, bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetMedicalCenterAddressByName(Name, trackChanges);
             var MapMCD = _mapper.Map(Address, GetMCD);
            await _repository.SaveAsync();
            return _mapper.Map<MedicalCenterAddressDto>(MapMCD);
        }
    }
}
