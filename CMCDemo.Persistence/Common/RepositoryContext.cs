using CMCDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMCDemo.Persistence.Common
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        { 
        
        }
        // linking models with the database

        public DbSet<Department> Departments { get; set; }
        public DbSet<Community_Medical_Centers> Community_Medical_Centers { get; set; }
        public DbSet<MedicalCenterAddress> MedicalCenterAddress { get;set; }
        public DbSet<ProfessionalStaff> ProfessionalStaff { get; set; }
        public DbSet<Ref_Disciplines> Ref_Disciplines { get; set; }
        public DbSet<StaffAddress> StaffAddress { get; set;}
        public DbSet<AppointmentCategory> AppointmentCategories { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<AuditableBaseEntity> AuditableBaseEntities { get; set; }
        public DbSet<CommonAddress> CommonAddress { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Ref_Appt_Locations> Ref_Appt_Locations { get; set; }
        public DbSet<Staff_in_Appointments> Staff_in_Appointments { get; set; }

    }
}

