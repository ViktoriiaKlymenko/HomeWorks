using EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DataContext Context;

        public BaseRepository(DataContext context)
        {
            Context = context;
        }
        public void Add(T item)
        {
            Context.Set<T>().Add(item);
        }

        public void AddRange(IEnumerable<T> item)
        {
            Context.Set<T>().AddRange(item);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T Find(Func<T, bool> predicate)
        {
            return Context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public void Remove(T item)
        {
            Context.Set<T>().Remove(item);
        }

        public void RemoveRange(IEnumerable<T> item)
        {
            Context.Set<T>().RemoveRange(item);
        }

        public int Count()
        {
            return Context.Set<T>().Count<T>();
        }

        public void Update(T item, T newItem)
        {
            Context.Set<T>().Update(item).CurrentValues.SetValues(item = newItem);
        }
    }
}
