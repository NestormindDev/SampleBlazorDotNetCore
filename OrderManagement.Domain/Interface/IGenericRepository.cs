using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Remove(T entity);
        Task<T> FilterExpressionAsync(Expression<Func<T, bool>> filter = null, params string[] includes);
        Task<List<T>> FilterExpressionRangeAsync(Expression<Func<T, bool>> filter = null, params string[] includes);
        IUnitOfWork UnitOfWork { get; }
    }
}
