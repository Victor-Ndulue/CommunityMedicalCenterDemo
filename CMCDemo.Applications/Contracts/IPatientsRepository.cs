using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IPatientsRepository
    {
        Task<IEnumerable<Patients>> GetAllPatientsAsync(bool trackchanges);
        Task<Patients> GetPatientsById(string Name, bool trackchanges);
        void Create(Patients entity);
        void Delete(Patients entity);
    }
}
