namespace EntityFrameworkTask
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public double Weight { get; set; }
        public int CategoryId { get; set; }
        public int ProviderId { get; set; }

        public Product(string name, decimal price, int amount, double weight, int categoryId, int providerId)
        {
            Id = new int();
            Price = price;
            Amount = amount;
            Weight = weight;
            CategoryId = categoryId;
            ProviderId = providerId;
        }
    }
}