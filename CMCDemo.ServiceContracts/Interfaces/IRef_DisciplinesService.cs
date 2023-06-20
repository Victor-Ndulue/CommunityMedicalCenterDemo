using CMCDemo.Applications.DTO_s.Ref_DisciplinesDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCDemo.ServiceContracts.Interfaces
{
    public interface IRef_DisciplinesService
    {
        Task <IEnumerable<Ref_DisciplinesDto>> GetAllDisciplinesAsync (bool trackChanges);
        Task<Ref_DisciplinesDto> GetDisciplinesAsync(int Id, bool trackChanges);
        Task <Ref_DisciplinesDto> CreateRef_Disciplines(Ref_DisciplinesForCreation creationDto);
        Task <Ref_DisciplinesDto> UpdateRef_Disciplines(int Id,  Ref_DisciplinesForUpdate updatedDto, bool trackChanges);
        Task DeleteRef_DisciplinesAsync(int Id, bool trackChanges);

    }
}
