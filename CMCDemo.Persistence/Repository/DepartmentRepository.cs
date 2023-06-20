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

        public void CreateDepartment(Department department)
        {
            Create(department);
        }

        public void DeleteDepartment(Department department)
        {
            Delete(department);
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Department> GetDepartmentById(int Id, bool trackchanges)
        {
            var Department = await FindByCondition(x => x.Id.Equals(Id), trackchanges).FirstOrDefaultAsync();
            if (Department == null)
            {
                throw new ArgumentException("Department not found!");
            }
            return Department;
        }

        public void UpdateDepartment(Department department)
        {
            Update(department);
        }
    }
}
