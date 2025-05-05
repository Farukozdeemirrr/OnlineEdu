using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAllList();
        T GetBydId(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
        int Count();
        T GetByFilter(Expression<Func<T, bool>> predicate);
        int FilteredCount(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetFilteredList(Expression<Func<T, bool>> predicate);


    }
}
