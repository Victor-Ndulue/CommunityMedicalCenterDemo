using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IStaffAddress
    {
        Task<IEnumerable<StaffAddress>> GetAllStaffAddressAsync(bool trackchanges);
        Task<StaffAddress> GetStaffAddressById(int Id, bool trackchanges);
        void CreateStaffAddress(StaffAddress entity);
        void DeleteStaffAddress(StaffAddress entity);
        void UpdateStaffAddress(StaffAddress entity);
    }
}
