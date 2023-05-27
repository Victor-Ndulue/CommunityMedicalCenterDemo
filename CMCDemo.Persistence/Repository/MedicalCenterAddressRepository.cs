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

        public void Create(MedicalCenterAddress medicalCenterAddress)
        {
            Create(medicalCenterAddress);
        }

        public void Delete(MedicalCenterAddress medicalCenterAddress)
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
            return await FindByCondition(x => x.StreetName== name, trackchanges).FirstOrDefaultAsync();

        }
    }
}
