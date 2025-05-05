using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;

namespace OnlineEdu.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public GenericManager(IRepository<T> repository) 
        {
            _repository = repository;
        }

        public T TAdd(T entity)
        {
            return _repository.Add(entity);        
        }

        public int TCount()
        {
           return _repository.Count();
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public int TFilteredCount(Expression<Func<T, bool>> predicate)
        {
           return _repository.FilteredCount(predicate);
        }

        public IEnumerable<T> TGetAllList()
        {
            return _repository.GetAllList();
        }

        public T TGetBydId(int id)
        {
            return _repository.GetBydId(id);  
            
        }

        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        public IEnumerable<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFilteredList(predicate);
        }

        public T TUpdate(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
