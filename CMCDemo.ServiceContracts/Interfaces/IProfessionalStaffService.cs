using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IProfessionalStaffService
    {
        Task<IEnumerable<ProfessionalStaffDto>> GetAllProfessionalStaffDtoAsync(bool trackChanges);
        Task <ProfessionalStaffDto> GetProfessionalStaffDtoAsync(string Name, bool trackChanges);
        Task<ProfessionalStaffDto> CreateProfessionalStaffDto(ProfessionalStaffForCreation  CreationDto);
        Task <ProfessionalStaffDto> UpdateProfessionalStaffAsync(string Name,ProfessionalStaffForUpdate professsionalStaffForUpdate, bool trackChanges);
        Task DeleteProfessionalStaffAsync(string Name,  bool trackChanges);
    }
}
