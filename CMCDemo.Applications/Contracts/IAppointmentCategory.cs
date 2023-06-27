using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IAppointmentCategory
    {
        Task<IEnumerable<AppointmentCategory>> GetAllAppointmentsCategoryAsync(bool trackchanges);
        Task<AppointmentCategory> GetAppointmentsCategoryByName(string Name, bool trackchanges);
        void Create(AppointmentCategory entity);
        void Delete(AppointmentCategory entity);
    }
}
