using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Context;

namespace OnlineEdu.DataAccess.Repositories
{   //.Net12 İle gelen primary constructor yerine genişletilebilirliği daha yüksek olan klasik constructor kullanıldı
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        //expression-bodied property (ifade gövdeli özellik)
        //DbSet<T> EF Core'da veritabanındaki tabloyu temsil eder. Örneğin: DbSet<Person> → Persons tablosu.
        public DbSet<T> Table => _context.Set<T>();


        public int Count()
        {
            return Table.Count();
        }

        public T Add(T entity)
        {
            Table.Add(entity);
            _context.SaveChanges(); 
            return entity;
        }

        public void Delete(int id)
        {
            var entity =Table.Find(id);
            Table.Remove(entity);
            
        }

        public int FilteredCount(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).Count();
        }

        public IEnumerable<T> GetAllList()
        {
           return Table.ToList();
        }

        public T GetBydId(int id)
        {
            return Table.Find(id);
        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).FirstOrDefault();
        }

        public IEnumerable<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public T Update(T entity)
        {
             Table.Update(entity);
            _context.SaveChanges();
            return entity;
           
        }
    }
}
