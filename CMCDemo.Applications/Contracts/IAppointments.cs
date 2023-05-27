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
        Task<IEnumerable<Appointments>> GetAllAppointmentsAsync(bool trackchanges);
        Task<Appointments> GetAppointmentsById(string Name, bool trackchanges);
        void Create(Appointments entity);
        void Delete(Appointments entity);
    }
}
