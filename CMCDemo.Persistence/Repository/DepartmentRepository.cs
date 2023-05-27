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
    internal sealed class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        

        void Create(Department department)
        {
            Create(department);
        }

        void Delete(Department department)
        {
            Delete(department);
        }
        public async Task<IEnumerable<Department>> GetAllDepartmentAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Department> GetDepartmentByName(string Name, bool trackchanges)
        {
            return await FindByCondition(x => x.DepartmentName == Name, trackchanges).FirstOrDefaultAsync();
        }
    }
}
