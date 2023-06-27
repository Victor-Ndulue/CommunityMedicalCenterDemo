using System.Linq.Expressions;

namespace CMCDemo.Applications.Common
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAllAsync(bool trackchanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackchanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
