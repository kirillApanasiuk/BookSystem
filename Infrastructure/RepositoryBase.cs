using Contexts;
using Microsoft.EntityFrameworkCore;
using Services;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly BookSystemContext _context;
        public RepositoryBase(BookSystemContext context)
        {
            _context = context;
        }

        public void Create(T entity)=>
            _context.Set<T>().Add(entity);

        public void Delete(T entity) =>
            _context.Set<T>().Remove(entity);

        public IQueryable<T> GetAll(bool trackChanges) => 
            !trackChanges ? 
            _context.Set<T>().AsNoTracking() : 
            _context.Set<T>();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> conditionExpr, bool trackChanges) =>
            !trackChanges ?
            _context.Set<T>().AsNoTracking().Where(conditionExpr) :
            _context.Set<T>().Where(conditionExpr);

        public void Update(T entity) => _context.Set<T>().Update(entity);
       
    }
}
