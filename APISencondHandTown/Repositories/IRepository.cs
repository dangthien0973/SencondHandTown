using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace APISencondHandTown.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Delete(int id);
        T Get( int id);
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void SaveChanges();
      
        
    }
}
