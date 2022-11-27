using System.Collections.Generic;

namespace ASP.Net_MVC.Abstract
{
    public interface IBaseRepository<T>
        where T : class , new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
    }
}
