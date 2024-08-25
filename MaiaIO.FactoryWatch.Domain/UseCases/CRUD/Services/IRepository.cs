using MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Services
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<IEnumerable<T>> SearchByCondition(Func<Expression> func);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
