using CMCDemo.Domain.Entities;
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
    }
}