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
<<<<<<< HEAD

=======
>>>>>>> Task4-APILayer
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

<<<<<<< HEAD
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return Context.Set<T>().Where(predicate);
=======
        public T Find(Func<T, bool> predicate)
        {
            return Context.Set<T>().Where(predicate).FirstOrDefault();
>>>>>>> Task4-APILayer
        }

        public void Remove(T item)
        {
            Context.Set<T>().Remove(item);
        }

        public void RemoveRange(IEnumerable<T> item)
        {
            Context.Set<T>().RemoveRange(item);
        }
<<<<<<< HEAD
    }
}
=======

        public int Count()
        {
            return Context.Set<T>().Count<T>();
        }
    }
}
>>>>>>> Task4-APILayer
