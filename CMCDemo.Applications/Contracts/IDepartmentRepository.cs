using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentAsync(bool trackchanges);
        Task<Department> GetDepartmentById(int Id, bool trackchanges);
        void CreateDepartment(Department entity);
        void UpdateDepartment(Department entity);
        void DeleteDepartment(Department entity);
    }
}
