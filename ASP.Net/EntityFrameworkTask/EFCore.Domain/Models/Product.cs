﻿namespace EntityFrameworkTask
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
    }
}