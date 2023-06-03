using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IAppointmentsCategory
    {
        Task<IEnumerable<AppointmentCategory>> GetAppointmentCategoryAsync(bool trackChanges);
        Task<AppointmentCategory> GetAppointmentCategoryByID(int id, bool trackChanges);
        void CreateAppointmentCategory(AppointmentCategory appointments);   
        void DeleteAppointmentCategory(AppointmentCategory appointments);
    }
}
