namespace PastriesDelivery
{
    /// <summary>
    /// This class describes pastry.
    /// </summary>
    public class Pastry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}