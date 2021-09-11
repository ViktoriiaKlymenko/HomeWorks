namespace EntityFrameworkTask
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public double Weight { get; set; }
        public Category Category { get; set; }
        public Provider Provider { get; set; }

        public Product(string name, decimal price, int amount, double weight, Category category, Provider provider)
        {
            Name = name;
            Amount = amount;
            Weight = weight;
            Category = category;
            Provider = provider;
        }
    }
}