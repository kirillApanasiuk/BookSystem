using System;
using System.Linq;
using System.Linq.Expressions;

namespace UseCases.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> conditionExpr, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
