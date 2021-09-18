using System;
using System.Collections.Generic;

namespace EFCore.Data.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
        where T : class
    {
        T Get(int id);
<<<<<<< HEAD

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Func<T, bool> predicate);

        void Add(T item); 

        void AddRange(IEnumerable<T> item); 

        void Remove(T item); 

        void RemoveRange(IEnumerable<T> item); 
    }
}
=======
        IEnumerable<T> GetAll();
        T Find(Func<T, bool> predicate);

        void Add(T item); 
        void AddRange(IEnumerable<T> item); 

        void Remove(T item); 
        void RemoveRange(IEnumerable<T> item);
        int Count();
    }
}
>>>>>>> Task4-APILayer
