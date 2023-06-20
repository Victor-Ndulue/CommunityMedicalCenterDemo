using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
