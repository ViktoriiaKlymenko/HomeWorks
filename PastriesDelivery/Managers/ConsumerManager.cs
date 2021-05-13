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

        public Storage SendOrderToStorage(Storage storage, Pastry pastry)
        {
            pastry.Price *= pastry.Amount;
            storage.Pastries.Add(pastry);
            storage.Type.Add(StorageType.UserOrders);
            return storage;
        }

        public Storage SendUserToStorage(Storage storage, User consumer)
        {
            storage.Users.Add(consumer);
            return storage;
        }
    }
}