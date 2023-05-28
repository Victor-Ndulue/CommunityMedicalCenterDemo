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

        public async Task<MedicalCenterAddress> GetMedicalCenterAddressByName(string name, bool trackchanges)
        {
            var MedicalCenterAddress = await FindByCondition(x => x.StreetName== name, trackchanges).FirstOrDefaultAsync();
            if (MedicalCenterAddress == null)
            {
                throw new Exception("Medical Center Address not found");
            }
                return MedicalCenterAddress;
        }
    }
}
