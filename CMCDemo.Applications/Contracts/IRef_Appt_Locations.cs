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
        Task<IEnumerable<Ref_Appt_Locations>> GetAllRef_Appt_LocationsAsync(bool trackChanges);
        Task<Ref_Appt_Locations> GetRef_Appt_LocationsById(int Id, bool trackChanges);
        void CreateRef_Appt_Locations(Ref_Appt_Locations location);
        void DeleteRef_Appt_Locations(Ref_Appt_Locations location); 
    }
}
