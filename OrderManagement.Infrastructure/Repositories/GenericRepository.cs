using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Interface;
using OrderManagement.Infrastructure.Context;

namespace OrderManagement.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly OrderManagementContext context;
        public IUnitOfWork UnitOfWork
        {
            get { return context; }
        }
        public GenericRepository(OrderManagementContext _context) 
        {
            this.context = _context;
        }
        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<T> FilterExpressionAsync(Expression<Func<T, bool>> filter = null, params string[] includes)
        {
            var query = context.Set<T>().AsNoTracking().AsQueryable();

            if (includes != null && includes.Length > 0)
                foreach (var include in includes)
                    query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);
            return await query.SingleOrDefaultAsync().ConfigureAwait(false);
        }
        public async Task<List<T>> FilterExpressionRangeAsync(Expression<Func<T, bool>> filter = null, params string[] includes)
        {
            var query = context.Set<T>().AsNoTracking().AsQueryable();

            if (includes != null && includes.Length > 0)
                foreach (var include in includes)
                    query = query.Include(include);

            if (filter != null)
                query = query.Where(filter);
            return await query.ToListAsync().ConfigureAwait(false);
        }
        public async Task<T> GetById(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            return entity;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            return entity;
        }
        public T Update(T entity)
        {
            return context.Set<T>()
              .Update(entity)
              .Entity;
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
    }
}
