﻿using CMCDemo.Applications.DTO_s;
using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface ICommunityMedicalCenterService
    {
        Task<IEnumerable<Community_Medical_CentersDto>> GetAllCMCDtoAsync(bool trackChanges);
        Task<Community_Medical_CentersDto> GetCMCDtoAsync(int Id, bool trackChanges);
        Task<Community_Medical_CentersDto> CreateCMCDto(Community_Medical_CentersForCreation creationDto);
        Task <Community_Medical_CentersDto> UpdateCMCDto(int Id, Community_Medical_CentersForUpdate community_Medical_CentersForUpdate, bool trackChanges);
        Task DeleteCMCDto(int Id, bool trackChanges);
    }
}
