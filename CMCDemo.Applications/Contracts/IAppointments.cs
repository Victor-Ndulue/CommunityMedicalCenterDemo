using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IAppointments
    {
        Task<IEnumerable<Appointments>> GetAppointmentsAsync(bool trackChanges);
        Task<Appointments> GetAppointmentsByID(int id, bool trackChanges);
        void CreateAppointments(Appointments appointments);
        void DeleteAppointments(Appointments appointments);
    }
}
