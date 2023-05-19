using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IRef_Appt_Locations
    {
        Task<IEnumerable<Ref_Appt_Locations>> GetAllRef_Appt_LocationsAsync(bool trackchanges);
        Task<Ref_Appt_Locations> GetRef_Appt_LocationsById(string Name, bool trackchanges);
        void Create(Ref_Appt_Locations entity);
        void Delete(Ref_Appt_Locations entity);
    }
}
