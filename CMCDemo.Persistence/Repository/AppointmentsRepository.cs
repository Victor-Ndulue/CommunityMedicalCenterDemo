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
    internal sealed class AppointmentsRepository : RepositoryBase<Appointments>, IAppointments
    {
        public AppointmentsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAppointments(Appointments appointments)
        {
            Create(appointments);
        }

        public void DeleteAppointments(Appointments appointments)
        {
            Delete(appointments);
        }

        public async Task<IEnumerable<Appointments>> GetAppointmentsAsync(bool trackChanges)
        {
            return await GetAllAsync(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Appointments> GetAppointmentsByID(int id, bool trackChanges)
        {
            var Appointments = FindByCondition(x => x.Id == id, trackChanges).FirstOrDefault();
            if (Appointments == null)
            {
                throw new Exception(" Appointment not found");
            }
            return Appointments;
        }
    }
}
