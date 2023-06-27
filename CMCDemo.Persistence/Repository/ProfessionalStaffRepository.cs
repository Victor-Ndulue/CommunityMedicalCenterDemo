using CMCDemo.Applications.Contracts;
using CMCDemo.Domain.Entities;
using CMCDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;

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

                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<ProfessionalStaff> GetProfessionalStaffById(int Id, bool trackchanges)
        {
            var ProfessionalStaff = await FindByCondition(x => x.Id.Equals(Id), trackchanges).FirstOrDefaultAsync();
            if (ProfessionalStaff == null)
            {
                throw new Exception("Staff not found!");
            }
            return ProfessionalStaff;
        }

        public void UpdateProfessionalStaff(ProfessionalStaff professionalStaff)
        {
            Update(professionalStaff);
        }
    }
}
