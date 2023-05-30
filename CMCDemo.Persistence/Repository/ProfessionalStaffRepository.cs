using CMCDemo.Applications.Contracts;
using CMCDemo.Domain.Entities;
using CMCDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Persistence.Repository
{
    internal sealed class ProfessionalStaffRepository : RepositoryBase<ProfessionalStaff>, IProfessionalStaff
    {
        public ProfessionalStaffRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProfessionalStaff(ProfessionalStaff professionalStaff)
        {
            Create(professionalStaff);
        }

        public void DeleteProfessionalStaff(ProfessionalStaff professionalStaff)
        {
            Delete(professionalStaff);
        }

        public async Task<IEnumerable<ProfessionalStaff>> GetAllProfessionalStaffAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)

                .OrderBy(x=> x.Id)
                .ToListAsync();
        }

        public async Task<ProfessionalStaff> GetProfessionalStaffByName(string Name, bool trackchanges)
        {
            var ProfessionalStaff = await FindByCondition(x => x.FirstName != null&&x.FirstName.Contains(Name) || x.LastName !=null &&x.LastName.Contains(Name), trackchanges).FirstOrDefaultAsync();
            if (ProfessionalStaff == null)
            {
                throw new Exception("Staff not found!");
            }
            return ProfessionalStaff;
        }
    }
}
