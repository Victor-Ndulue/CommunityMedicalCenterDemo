using CMCDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CMCPersistence.Context
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }
        // linking models with the database
        DbSet<AppointmentCategory> AppointmentCategories { get; set; }
        DbSet<Appointments> Appointments { get; set; }
        DbSet<AuditableBaseEntity> AuditableBaseEntities { get; set; }
        DbSet<CommonAddress> CommonAddress { get; set; }
        DbSet<Community_Medical_Centers> Community_Medical_Centers { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<MedicalCenterAddress> Medical_Centers { get;set; }
        DbSet<Patients> Patients { get; set; }
        DbSet<ProfessionalStaff> ProfessionalStaff { get; set;}
        DbSet<Ref_Appt_Locations> Ref_Appt_Locations { get; set;}
        DbSet<Ref_Disciplines> Ref_Disciplines { get; set; }
        DbSet<Staff_in_Appointments> Staff_in_Appointments { get; set; }
        DbSet<StaffAddress> Staff_address { get; set;}
    }
}
