using CMCDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
