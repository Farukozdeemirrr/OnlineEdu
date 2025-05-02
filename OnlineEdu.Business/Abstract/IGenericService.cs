using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> TGetAllList();
        T TGetBydId(int id);
        T TAdd(T entity);
        T TUpdate(T entity);
        void TDelete(int id);
        int TCount();
        T TGetByFilter(Expression<Func<T, bool>> predicate);
        int TFilteredCount(Expression<Func<T, bool>> predicate);
        IEnumerable<T> TGetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
