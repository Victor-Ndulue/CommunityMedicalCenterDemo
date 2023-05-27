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

        public void Create(ProfessionalStaff professionalStaff)
        {
            Create(professionalStaff);
        }

        public void Delete(ProfessionalStaff professionalStaff)
        {
            Delete(professionalStaff);
        }

        public async Task<IEnumerable<IProfessionalStaff>> GetAllProfessionalStaffAsync(bool trackchanges)
        {
            return (IEnumerable<IProfessionalStaff>)await GetAllAsync(trackchanges)
                .OrderBy(x=> x.Id)
                .ToListAsync();
        }

        public async Task<ProfessionalStaff> GetProfessionalStaffByName(string firstName, string lastName, bool trackchanges)
        {
            return await FindByCondition(x => x.FirstName == firstName || x.LastName == lastName, trackchanges).FirstOrDefaultAsync();
        }
    }
}
