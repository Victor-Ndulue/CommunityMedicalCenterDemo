using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IAppointments
    {
        Task<IEnumerable<Appointments>> GetAllAppointmentsAsync(bool trackchanges);
        Task<Appointments> GetAppointmentsById(string Name, bool trackchanges);
        void Create(Appointments entity);
        void Delete(Appointments entity);
    }
}
