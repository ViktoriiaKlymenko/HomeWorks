using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Interfaces
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);

        void Add(T item); 
        void AddRange(IEnumerable<T> item); 

        void Remove(T item); 
        void RemoveRange(IEnumerable<T> item); 
    }
}
