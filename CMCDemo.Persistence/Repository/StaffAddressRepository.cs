using CMCDemo.Applications.Contracts;
using CMCDemo.Domain.Entities;
using CMCDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace CMCDemo.Persistence.Repository
{
    internal sealed class StaffAddressRepository : RepositoryBase<StaffAddress>, IStaffAddress
    {
        public StaffAddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public void CreateStaffAddress(StaffAddress staffAddress)
        {
            Create(staffAddress);
        }

        public void DeleteStaffAddress(StaffAddress staffAddress)
        {
            Delete(staffAddress);
        }

        public async Task<IEnumerable<StaffAddress>> GetAllStaffAddressAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<StaffAddress> GetStaffAddressById(int Id, bool trackchanges)
        {
            var StaffAddress = await FindByCondition(x => x.Id.Equals(Id), trackchanges).FirstOrDefaultAsync();
            if (StaffAddress == null)
            {
                throw new Exception("Staff address not found!");
            }
            return StaffAddress;
        }

        public void UpdateStaffAddress(StaffAddress staffAddress)
        {
            Update(staffAddress);
        }
    }
}
