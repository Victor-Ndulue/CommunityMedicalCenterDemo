﻿using CMCDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMCDemo.Persistence.Common
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        { 
        
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Community_Medical_Centers> Community_Medical_Centers { get; set; }
        public DbSet<MedicalCenterAddress> MedicalCenterAddress { get;set; }
        public DbSet<ProfessionalStaff> ProfessionalStaff { get; set; }
        public DbSet<Ref_Disciplines> Ref_Disciplines { get; set; }
        public DbSet<StaffAddress> StaffAddress { get; set;}
    }
}