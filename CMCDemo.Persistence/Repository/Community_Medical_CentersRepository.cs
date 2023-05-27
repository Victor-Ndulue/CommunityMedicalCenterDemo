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

        public void Create(Community_Medical_Centers community_Medical_Centers)
        {
            Create(community_Medical_Centers);
        }

        public void Delete(Community_Medical_Centers community_Medical_Centers)
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
            return await FindByCondition(x => x.MedicalCenterName == Name, trackchanges).FirstOrDefaultAsync();
        }
    }
}
