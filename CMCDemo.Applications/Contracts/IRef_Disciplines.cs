using CMCDemo.Domain.Entities;

namespace CMCDemo.Applications.Contracts
{
    public interface IRef_Disciplines
    {
        Task<IEnumerable<Ref_Disciplines>> GetAllRef_DisciplinesAsync(bool trackchanges);

        Task<Ref_Disciplines> GetRef_DisciplinesById(int Id, bool trackchanges);
        void CreateRef_Disciplines(Ref_Disciplines entity);
        void UpdateRef_Disciplines(Ref_Disciplines entity);
        void DeleteRef_Disciplines(Ref_Disciplines entity);
    }
}
