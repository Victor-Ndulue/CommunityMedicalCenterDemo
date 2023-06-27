using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s.MedicalCenterAddressDTOS;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;

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
            var mappedEntity = _mapper.Map<MedicalCenterAddress>(creationDto);
            _repository.MedicalCenterAddress.CreateMedicalCenterAddress(mappedEntity);
            await _repository.SaveAsync();
            var mappedDto = _mapper.Map<MedicalCenterAddressDto>(mappedEntity);
            return mappedDto;
        }

        public async Task DeleteMedicalCenterAddress(int Id, bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetMedicalCenterAddressById(Id, trackChanges);
            _repository.MedicalCenterAddress.DeleteMedicalCenterAddress(GetMCD);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<MedicalCenterAddressDto>> GetAllMedicalCenterAddress(bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetAllMedicalCenterAddressesAsync(trackChanges);
            var MapMCD = _mapper.Map<IEnumerable<MedicalCenterAddressDto>>(GetMCD);
            return MapMCD;
        }

        public async Task<MedicalCenterAddressDto> GetMedicalCenterAddressById(int Id, bool trackChanges)
        {
            var GetMCD = await _repository.MedicalCenterAddress.GetMedicalCenterAddressById(Id, trackChanges);
            var MapMCD = _mapper.Map<MedicalCenterAddressDto>(GetMCD);
            return MapMCD;
        }

        public async Task<MedicalCenterAddressDto> UpdateMedicalCenterAddress(int Id, MedicalCenterAddressForUpdate Address, bool trackChanges)
        {
            var GetAddress = await _repository.MedicalCenterAddress.GetMedicalCenterAddressById(Id, trackChanges);
            var MapAddress = _mapper.Map(Address, GetAddress);
            _repository.MedicalCenterAddress.UpdateMedicalCenterAddress(MapAddress);
            await _repository.SaveAsync();
            return _mapper.Map<MedicalCenterAddressDto>(MapAddress);
        }
    }
}
