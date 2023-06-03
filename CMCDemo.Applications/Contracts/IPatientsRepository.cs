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
        Task<IEnumerable<Patients>> GetAllPatientsAsync(bool trackChanges);
        Task<Patients> GetPatientsByName(string Name, bool trackChanges);   
        void CreatePatient(Patients patients);
        void DeletePatient(Patients patients);
    }
}
