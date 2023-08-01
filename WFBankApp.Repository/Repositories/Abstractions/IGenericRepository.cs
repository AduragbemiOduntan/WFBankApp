using WFbankApp.Models.Models;

namespace WFBankApp.Repository.Repositories.Abstractions
{
    public interface IGenericRepository<T> 
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);
       
    }
}
