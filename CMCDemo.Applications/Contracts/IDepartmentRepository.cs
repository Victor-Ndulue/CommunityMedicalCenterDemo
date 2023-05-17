using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllAsync(bool trackchanges);
        Task<Department> GetAddressById(string Name, bool trackchanges);
        void Create(Department entity);
        void Delete(Department entity);
    }
}
