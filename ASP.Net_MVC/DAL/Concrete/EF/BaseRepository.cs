using ASP.Net_MVC.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ASP.Net_MVC.Concrete.EF
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class, new()
    {
        public void Add(T entity)
        {
            using(var _context = new NorthwindDbContext())
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var _context = new NorthwindDbContext())
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var _context = new NorthwindDbContext())
            {
                return _context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new NorthwindDbContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
