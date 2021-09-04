using System;
using System.Collections.Generic;

namespace EFCore.Data.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
        where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Find(Func<T, bool> predicate);

        void Add(T item); 
        void AddRange(IEnumerable<T> item); 

        void Remove(T item); 
        void RemoveRange(IEnumerable<T> item);
        int Count();
        void Update(T item, T newItem);
    }
}
