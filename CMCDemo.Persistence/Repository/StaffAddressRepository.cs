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
    internal sealed class StaffAddressRepository : RepositoryBase<StaffAddress> , IStaffAddress
    {
        public StaffAddressRepository(RepositoryContext repositoryContext):base(repositoryContext) 
        {
        }
        public void Create(StaffAddress staffAddress)
        {
            Create(staffAddress);
        }

        public void Delete(StaffAddress staffAddress)
        {
            Delete(staffAddress);
        }

        public async Task<IEnumerable<StaffAddress>> GetAllStaffAddressAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<StaffAddress> GetStaffAddressByName(string Name, bool trackchanges)
        {
            return await FindByCondition(x => x.StreetName == Name, trackchanges).FirstOrDefaultAsync(); 
        }
        
    }
}
