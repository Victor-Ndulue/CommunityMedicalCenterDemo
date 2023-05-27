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
        Task<IEnumerable<IProfessionalStaff>> GetAllProfessionalStaffAsync(bool trackchanges);
        Task<ProfessionalStaff> GetProfessionalStaffByName(string firstName, string lastName, bool trackchanges);
        void Create(ProfessionalStaff entity);
        void Delete(ProfessionalStaff entity);
    }
}
