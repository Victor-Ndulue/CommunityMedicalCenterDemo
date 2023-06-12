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
    internal sealed class Community_Medical_CentersRepository : RepositoryBase<Community_Medical_Centers>, ICommunity_Medical_CentersRepository
    {
        public Community_Medical_CentersRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateCommunity_Medical_Centers(Community_Medical_Centers community_Medical_Centers)
        {
            Create(community_Medical_Centers);
        }
        public void UpdateCommunity_Medical_Centers(Community_Medical_Centers community_Medical_Centers)
        {
            Update(community_Medical_Centers);
        }

        public void DeleteCommunity_Medical_Centers(Community_Medical_Centers community_Medical_Centers)
        {
            Delete(community_Medical_Centers);
        }

        public async Task<IEnumerable<Community_Medical_Centers>> GetAllCommunity_Medical_CenterAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Community_Medical_Centers> GetCommunity_Medical_CenterByName(string Name, bool trackchanges)
        {
            var Community_Medical_Center = await FindByCondition(x => x.MedicalCenterName != null && x.MedicalCenterName.Contains(Name), trackchanges).FirstOrDefaultAsync();
            if (Community_Medical_Center == null)
            {
                throw new Exception("Medical Center not found!");
            }
            return Community_Medical_Center;
        }
    }
}
