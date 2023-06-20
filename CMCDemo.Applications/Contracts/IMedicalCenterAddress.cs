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
        Task<IEnumerable<MedicalCenterAddress>> GetAllMedicalCenterAddressesAsync(bool trackchanges);
        Task<MedicalCenterAddress> GetMedicalCenterAddressById(int Id, bool trackchanges);
        void UpdateMedicalCenterAddress(MedicalCenterAddress medicalCenterAddress);
        void CreateMedicalCenterAddress(MedicalCenterAddress entity);
        void DeleteMedicalCenterAddress(MedicalCenterAddress entity);
    }
}
