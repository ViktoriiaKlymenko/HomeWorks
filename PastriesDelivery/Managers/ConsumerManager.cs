namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : IOrderMaker
    {
        private readonly IStorage _storage;

        public ConsumerManager(IStorage storage)
        {
            _storage = storage;
        }

        public bool CheckForDataPrescence()
        {
            if (_storage.Pastries.Count == 0)
            {
                return false;
            }
            return true;
        }

        public Pastry ChooseProduct(int id, int amount)
        {
            var pastry = new Pastry();
            for (int i = 0; i < _storage.Pastries.Count; i++)
            {
                if (_storage.Type[i] == StorageType.AvailableProducts)
                {
                    var product = _storage.Pastries[i];

                    if (id == product.Id)
                    {
                        pastry = product;
                        RemoveFromAvailableProducts(amount, product);
                    }
                }
            }
            return pastry;
        }

        internal bool CheckAmount(int id, int amount)
        {
            for (int i = 0; i < _storage.Pastries.Count; i++)
            {
                var pastry = _storage.Pastries[i];
                if (amount > pastry.Amount && id == pastry.Id)
                {
                    return false;
                }
            }
            return true;
        }

        private void RemoveFromAvailableProducts(int amount, Pastry product)
        {
            foreach (var pastry in _storage.Pastries)
            {
                if (pastry == product)
                {
                    if (amount == product.Amount)
                    {
                        _storage.Pastries.Remove(product);
                    }
                    if (amount < product.Amount)
                    {
                        pastry.Amount -= amount;
                    }
                }
            }
        }

        public void SaveOrder(Pastry pastry)
        {
            pastry.Price *= pastry.Amount;
            _storage.Pastries.Add(pastry);
            _storage.Type.Add(StorageType.UserOrders);
        }

        public void SaveUser(User consumer)
        {
            _storage.Users.Add(consumer);
        }
    }
}