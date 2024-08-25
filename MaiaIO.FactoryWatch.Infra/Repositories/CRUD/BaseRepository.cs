using MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Infra.Repositories.CRUD
{
    public class BaseRepositor<T> : IRepository<T> where T : class
    {

        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepositor(DbContext context) 
        {
            _context = context;
            _dbSet = DbSet<T>;
        }

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task<T> DeleteAsync(T entity)
        {
            await _context.Set<T>.DeleteAsync(entity);
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> SearchByCondition(Func<Expression> func)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
