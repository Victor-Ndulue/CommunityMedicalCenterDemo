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
    internal sealed class MedicalCenterAddressRepository : RepositoryBase<MedicalCenterAddress>, IMedicalCenterAddress
    {
        public MedicalCenterAddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateMedicalCenterAddress(MedicalCenterAddress medicalCenterAddress)
        {
            Create(medicalCenterAddress);
        }

        public void UpdateMedicalCenterAddress(MedicalCenterAddress medicalCenterAddress)
        {
            Update(medicalCenterAddress);
        }

        public void DeleteMedicalCenterAddress(MedicalCenterAddress medicalCenterAddress)
        {
            Delete(medicalCenterAddress);
        }

        public async Task<IEnumerable<MedicalCenterAddress>> GetAllMedicalCenterAddressesAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<MedicalCenterAddress> GetMedicalCenterAddressById(int Id, bool trackchanges)
        {
            var MedicalCenterAddress = await FindByCondition(x =>x.Id.Equals(Id), trackchanges).FirstOrDefaultAsync();
            if (MedicalCenterAddress == null)
            {
                throw new Exception("Medical Center Address not found");
            }
                return MedicalCenterAddress;
        }
    }
}
