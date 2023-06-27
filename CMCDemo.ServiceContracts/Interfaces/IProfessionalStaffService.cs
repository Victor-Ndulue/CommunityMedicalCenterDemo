using CMCDemo.Applications.DTO_s.ProfessionalStaffDTOS;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IProfessionalStaffService
    {
        Task<IEnumerable<ProfessionalStaffDto>> GetAllProfessionalStaffDtoAsync(bool trackChanges);
        Task<ProfessionalStaffDto> GetProfessionalStaffDtoAsync(int Id, bool trackChanges);
        Task<ProfessionalStaffDto> CreateProfessionalStaffDto(ProfessionalStaffForCreation CreationDto);
        Task<ProfessionalStaffDto> UpdateProfessionalStaffAsync(int Id, ProfessionalStaffForUpdate professsionalStaffForUpdate, bool trackChanges);
        Task DeleteProfessionalStaffAsync(int Id, bool trackChanges);
    }
}
