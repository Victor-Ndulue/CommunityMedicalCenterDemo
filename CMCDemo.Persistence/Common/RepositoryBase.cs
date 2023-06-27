using CMCDemo.Applications.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CMCDemo.Persistence.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        //--Implementing Dependency Injection--
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> GetAllAsync(bool trackchanges)
        {
            return !trackchanges ?
            RepositoryContext.Set<T>()
            .AsNoTracking() :
            RepositoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackchanges)
        {
            return !trackchanges ?
            RepositoryContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
            RepositoryContext.Set<T>()
            .Where(expression);

        }

        public void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }
    }
}
