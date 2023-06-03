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
    internal sealed class AppointmentCategoryRepository : RepositoryBase<AppointmentCategory>, IAppointmentsCategory
    {
        public AppointmentCategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAppointmentCategory(AppointmentCategory appointmentsCategory)
        {
            Create(appointmentsCategory);
        }

        public void DeleteAppointmentCategory(AppointmentCategory appointmentsCategory)
        {
            Delete(appointmentsCategory);
        }

        public async Task<IEnumerable<AppointmentCategory>> GetAppointmentCategoryAsync(bool trackChanges)
        {
             
            return await GetAllAsync(trackChanges)
                .OrderBy(x => x.Appointments_ID)
                .ToListAsync();
        }


        public async Task<AppointmentCategory> GetAppointmentCategoryByID(int id, bool trackChanges)
        {
            var AppointmentCategory = await FindByCondition(x => x != null && x.Appointments_ID==id, trackChanges).FirstOrDefaultAsync();
            if (AppointmentCategory == null)
            {
                throw new ArgumentException("Appointment Category not found!");
            }
            return AppointmentCategory;
        }
    }
}
