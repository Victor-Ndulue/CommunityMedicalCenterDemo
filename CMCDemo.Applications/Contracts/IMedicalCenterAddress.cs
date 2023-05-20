using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.Applications.Contracts
{
    public interface IMedicalCenterAddress
    {
        Task<IEnumerable<MedicalCenterAddress>> GetAllMedicalCenterAddressesAsync();
        Task<MedicalCenterAddress> GetMedicalCenterAddressByName(string name, bool trackchanges);
        void Create(MedicalCenterAddress entity);
        void Delete(MedicalCenterAddress entity);
    }
}
