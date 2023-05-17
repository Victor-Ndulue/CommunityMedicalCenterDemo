using CMCDemo.Applications.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Common
{
    public interface IRepositoryManager
    {
        ICommunity_Medical_CentersRepository Community_Medical_Centers { get; }
        IDepartmentRepository Department { get; }

        Task SaveAsync();
    }
}
