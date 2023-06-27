using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IProfessionalStaff
    {
        Task<IEnumerable<ProfessionalStaff>> GetAllProfessionalStaffAsync(bool trackchanges);
        Task<ProfessionalStaff> GetProfessionalStaffById(int Id, bool trackchanges);
        void CreateProfessionalStaff(ProfessionalStaff entity);
        void UpdateProfessionalStaff(ProfessionalStaff entity);
        void DeleteProfessionalStaff(ProfessionalStaff entity);
    }
}
