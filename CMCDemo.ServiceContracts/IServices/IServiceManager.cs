using CMCDemo.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceContracts.IServices
{
    public interface IServiceManager
    {
        IProfessionalStaffService ProfessionalStaffService { get; }
    }
}
