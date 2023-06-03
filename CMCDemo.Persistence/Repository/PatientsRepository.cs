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
    internal sealed class PatientsRepository : RepositoryBase<Patients>, IPatientsRepository
    {
        public PatientsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreatePatient(Patients patients)
        {
            Create(patients);
        }

        public void DeletePatient(Patients patients)
        {
            Delete(patients);
        }

        public async Task<IEnumerable<Patients>> GetAllPatientsAsync(bool trackChanges)
        {
            return await GetAllAsync(trackChanges)
                .OrderBy(x => x.Patient_ID)
                .ToListAsync();
        }

        public Task<Patients> GetPatientsByName(string Name, bool trackChanges)
        {
            return (Task<Patients>)FindByCondition(x => x.First_Name.Contains(Name) || x.Last_Name.Contains(Name), trackChanges);
        }
    }
}
