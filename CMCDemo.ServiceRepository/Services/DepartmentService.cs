﻿using AutoMapper;
using CMCDemo.Applications.Common;
using CMCDemo.Applications.DTO_s.DepartmentDTOS;
using CMCDemo.Domain.Entities;
using CMCDemo.ServiceContracts.Interfaces;

namespace CMCDemo.ServiceRepository.Services
{
    internal class DepartmentService : IDepartmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public DepartmentService(IRepositoryManager repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }
        public async Task<DepartmentDto> CreateDepartment(DepartmentForCreation creationDto)
        {
            var MapDepartment = _mapper.Map<Department>(creationDto);
            _repository.Department.CreateDepartment(MapDepartment);
            await _repository.SaveAsync();
            return _mapper.Map<DepartmentDto>(creationDto);
        }

        public async Task DeleteDepartment(int Id, bool trackChanges)
        {
            var GetDepartment = await _repository.Department.GetDepartmentById(Id, trackChanges);
            _repository.Department.DeleteDepartment(GetDepartment);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentDto(bool trackChanges)
        {
            var GetDept = await _repository.Department.GetAllDepartmentAsync(trackChanges);
            var MapDepartment = _mapper.Map<IEnumerable<DepartmentDto>>(GetDept);
            return MapDepartment;

        }

        public async Task<DepartmentDto> GetDepartmentDto(int Id, bool trackChanges)
        {
            var GetDept = await _repository.Department.GetDepartmentById(Id, trackChanges);
            var MapDept = _mapper.Map<DepartmentDto>(GetDept);
            return MapDept;
        }

        public async Task<DepartmentDto> UpdateDepartment(int Id, DepartmentForUpdate departmentDto, bool trackChanges)
        {
            var GetDept = await _repository.Department.GetDepartmentById(Id, trackChanges);
            var MapDept = _mapper.Map(departmentDto, GetDept);
            _repository.Department.UpdateDepartment(MapDept);
            await _repository.SaveAsync();
            return _mapper.Map<DepartmentDto>(MapDept);
        }
    }
}
