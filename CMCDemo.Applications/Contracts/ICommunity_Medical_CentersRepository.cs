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
        Task<IEnumerable<Community_Medical_Centers>> GetAllAsync();
        Task<Community_Medical_Centers> GetByName(string Name, bool trackchanges);
        void Create(Community_Medical_Centers entity);
        void Delete(Community_Medical_Centers entity);
    }
}
