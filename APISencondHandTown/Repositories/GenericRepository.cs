using APISencondHandTown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace APISencondHandTown.Repositories
{
    public abstract class GenericRepository<T>
        : IRepository<T> where T : class
    {
        protected readonly DB_TMDTContext context;

        public GenericRepository(DB_TMDTContext context)
        {
            this.context = context;
        }

        public virtual T Add(T entity)
        {
            return context
                .Add(entity)
                .Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        public virtual T Get(int id)
        {
            return context.Find<T>(id);
        }

        public virtual IEnumerable<T> All()
        {
            return context.Set<T>()
                .ToList();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity)
                .Entity;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T Delete(T entity)
        {
            return context.Remove(entity).Entity;
        }

        public T Delete(int id)
        {
            var entity = context.Find<T>(id);
            return context.Remove(entity).Entity;
        }
    }
}
