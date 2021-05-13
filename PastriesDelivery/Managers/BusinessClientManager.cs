namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with business client.
    /// </summary>
    public class BusinessClientManager : IOrderMaker
    {
        private readonly IStorage _storage;

        public BusinessClientManager(IStorage storage)
        {
            _storage = storage;
        }

        public bool CheckForDataPrescence()
        {
            if (_storage.Pastries.Count is 0)
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

        public void SendOrderToStorage(Pastry pastry)
        {
            pastry.Price *= pastry.Amount;
            ApplyDiscount(pastry);
            _storage.Pastries.Add(pastry);
            _storage.Type.Add(StorageType.UserOrders);
        }

        public void SendUserToStorage(User businessClient)
        {
            _storage.Users.Add(businessClient);
        }

        private static Pastry ApplyDiscount(Pastry pastry)
        {
            if (pastry.Amount > 19 && pastry.Amount < 50)
            {
                pastry.Price -= pastry.Price / 100 * (int)DiscountPercents.TwentyUnits;
            }
            if (pastry.Amount > 49 && pastry.Amount < 100)
            {
                pastry.Price -= pastry.Price / 100 * (int)DiscountPercents.FiftyUnits;
            }
            if (pastry.Amount > 99)
            {
                pastry.Price -= pastry.Price / 100 * (int)DiscountPercents.HundredUnits;
            }
            return pastry;
        }
    }
}