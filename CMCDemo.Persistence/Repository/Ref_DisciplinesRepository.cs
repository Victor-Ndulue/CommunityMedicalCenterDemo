﻿using CMCDemo.Applications.Contracts;
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
    internal sealed class Ref_DisciplinesRepository : RepositoryBase<Ref_Disciplines>, IRef_Disciplines
    {
        public Ref_DisciplinesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public void Create(Ref_Disciplines ref_Disciplines)
        {
            Create(ref_Disciplines);
        }

        public void Delete(Ref_Disciplines ref_Disciplines)
        {
            Delete(ref_Disciplines);
        }
        public async Task<IEnumerable<Ref_Disciplines>> GetAllRef_DisciplinesAsync(bool trackchanges)
        {
            return await GetAllAsync(trackchanges)
                .OrderBy(x=>x.Ref_DisciplinesId)
                .ToListAsync();
        }

        public async Task<Ref_Disciplines> GetRef_DisciplinesByName(string name, bool trackchanges)
        {
            return await FindByCondition(x => x.DisciplinesName == name, trackchanges).FirstOrDefaultAsync();
        }
    }
}
