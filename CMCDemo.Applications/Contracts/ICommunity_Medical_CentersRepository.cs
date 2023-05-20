using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface ICommunity_Medical_CentersRepository
    {
        Task<IEnumerable<Community_Medical_Centers>> GetAllCommunity_Medical_CenterAsync(bool trackchanges);
        Task<Community_Medical_Centers> GetCommunity_Medical_CenterByName(string Name, bool trackchanges);
        void Create(Community_Medical_Centers entity);
        void Delete(Community_Medical_Centers entity);
    }
}
