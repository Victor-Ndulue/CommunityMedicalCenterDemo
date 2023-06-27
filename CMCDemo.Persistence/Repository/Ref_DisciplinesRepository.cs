using CMCDemo.Applications.Contracts;
using CMCDemo.Domain.Entities;
using CMCDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace CMCDemo.Persistence.Repository
{
    internal sealed class Ref_DisciplinesRepository : RepositoryBase<Ref_Disciplines>, IRef_Disciplines
    {
        public Ref_DisciplinesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public void CreateRef_Disciplines(Ref_Disciplines ref_Disciplines)
        {
            Create(ref_Disciplines);
        }

        public void DeleteRef_Disciplines(Ref_Disciplines ref_Disciplines)
        {
            Delete(ref_Disciplines);
        }
        public async Task<IEnumerable<Ref_Disciplines>> GetAllRef_DisciplinesAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Ref_DisciplinesId)
                .ToListAsync();
        }

        public async Task<Ref_Disciplines> GetRef_DisciplinesById(int Id, bool trackchanges)
        {
            var Ref_Disciplines = await FindByCondition(x => x.Ref_DisciplinesId.Equals(Id), trackchanges).FirstOrDefaultAsync();
            if (Ref_Disciplines == null)
            {
                throw new Exception("Discipline not found");
            }
            return Ref_Disciplines;
        }

        public void UpdateRef_Disciplines(Ref_Disciplines ref_Disciplines)
        {
            Update(ref_Disciplines);
        }
    }
}
