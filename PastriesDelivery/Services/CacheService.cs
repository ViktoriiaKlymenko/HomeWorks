using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PastriesDelivery
{
    public class CacheService : ICacheService
    {
        private readonly ICache _cache;
        private readonly IStorage _storage;

        public CacheService(ICache cache, IStorage storage)
        {
            _cache = cache;
            _storage = storage;
        }

        public Pastry Get(int id, int amount)
        {
            var locker = new object();
            var pastry = _cache.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry;
            if (pastry is null)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (amount < pastry.Amount || pastry.Amount == amount)
            {
                lock (locker)
                {
                    _storage.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry.Amount -= amount;
                    _cache.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry.Amount -= amount;
                    return pastry;
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        public void Set(Product product)
        {
            var locker = new object();
            if (_cache.Products.Count == 5)
            {
                if (_cache.Products.Peek().Pastry.Amount == 0)
                {
                    lock (locker)
                    {
                        _storage.Products.Remove(_cache.Products.Peek());
                    }
                }

                if (product.Pastry.Amount < _storage.Products.FirstOrDefault(productFromStorage => productFromStorage == _cache.Products.Peek()).Pastry.Amount)
                {
                    lock (locker)
                    {
                        _storage.Products.FirstOrDefault(productFromStorage => productFromStorage == _cache.Products.Peek()).Pastry.Amount = product.Pastry.Amount;
                    }
                }
                lock (locker)
                {
                    _cache.Products.Dequeue();
                }
            }
            lock (locker)
            {
                _cache.Products.Enqueue(product);
            }
        }
    }
}
