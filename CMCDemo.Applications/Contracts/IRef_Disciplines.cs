using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IRef_Disciplines
    {
        Task<IEnumerable<Ref_Disciplines>> GetAllRef_DisciplinesAsync(bool trackchanges);
     
        Task<Ref_Disciplines> GetRef_DisciplinesByName(string name, bool trackchanges);
        void Create(Ref_Disciplines entity);
        void Delete(Ref_Disciplines entity);
    }
}
