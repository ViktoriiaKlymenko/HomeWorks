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
        private readonly object _lock;
        private readonly IStorage _storage;


        public CacheService(ICache cache, object lok, IStorage storage)
        {
            _cache = cache;
            _lock = lok;
            _storage = storage;
        }

        public Pastry ExtractFromCache(int id, int amount)
        {
            if (_cache.Products.Any())
            {
                var pastry = _cache.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry;

                if (amount < pastry.Amount || pastry.Amount == amount)
                {
                    _storage.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry.Amount -= amount;
                    _cache.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry.Amount -= amount;
                    return pastry;
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        public void SaveToCache(Product product)
        {
            if (_cache.Products.Count == 5)
            {
                if (_cache.Products.Peek().Pastry.Amount == 0)
                {
                    _storage.Products.Remove(_cache.Products.Peek());
                }

                if (product.Pastry.Amount < _storage.Products.FirstOrDefault(productFromStorage => productFromStorage == _cache.Products.Peek()).Pastry.Amount)
                {
                    _storage.Products.FirstOrDefault(productFromStorage => productFromStorage == _cache.Products.Peek()).Pastry.Amount = product.Pastry.Amount;
                }

                _cache.Products.Dequeue();
            }
            _cache.Products.Enqueue(product);
        }
    }
}
