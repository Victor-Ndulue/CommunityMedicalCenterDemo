using CMCDemo.Applications.DTO_s.DepartmentDTOS;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentDto(bool trackChanges);
        Task<DepartmentDto> GetDepartmentDto(int Id, bool trackChanges);
        Task<DepartmentDto> CreateDepartment(DepartmentForCreation creationDto);
        Task<DepartmentDto> UpdateDepartment(int Id, DepartmentForUpdate departmentDto, bool trackChanges);
        Task DeleteDepartment(int Id, bool trackChanges);
    }
}
