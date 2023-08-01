using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFbankApp.Models.Models;
using WFBankApp.Repository.Data;
using WFBankApp.Repository.Repositories.Abstractions;

namespace WFBankApp.Repository.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BankDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(BankDbContext dbContext) 
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async void Create(T entity)
        {
             await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
        }

/*        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return _dbSet;
        }*/

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
