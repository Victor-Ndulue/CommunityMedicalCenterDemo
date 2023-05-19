using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IAppointmentCategory
    {
        Task<IEnumerable<AppointmentCategory>> GetAllAppointmentsCategoryAsync(bool trackchanges);
        Task<AppointmentCategory> GetAppointmentsCategoryById(string Name, bool trackchanges);
        void Create(AppointmentCategory entity);
        void Delete(AppointmentCategory entity);
    }
}
