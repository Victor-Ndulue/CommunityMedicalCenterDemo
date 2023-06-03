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
    internal sealed class Ref_Appt_LocationsRepository : RepositoryBase<Ref_Appt_Locations>, IRef_Appt_Locations
    {
        public Ref_Appt_LocationsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateRef_Appt_Locations(Ref_Appt_Locations location)
        {
            Create(location);
        }

        public void DeleteRef_Appt_Locations(Ref_Appt_Locations location)
        {
            Delete(location);
        }

        public async Task<IEnumerable<Ref_Appt_Locations>> GetAllRef_Appt_LocationsAsync(bool trackChanges)
        {
            return await GetAllAsync(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Ref_Appt_Locations> GetRef_Appt_LocationsById(int Id, bool trackChanges)
        {
            var Ref_Appointment_Location = FindByCondition(x => x.Id == Id, trackChanges).FirstOrDefault();
            if (Ref_Appointment_Location == null)
            {
                throw new Exception("Ref Appointment Location not found");
            }
            return Ref_Appointment_Location;
        }
    }
}
