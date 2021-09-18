<<<<<<< HEAD
﻿namespace EntityFrameworkTask
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTask
>>>>>>> Task4-APILayer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
<<<<<<< HEAD
        public int CategoryId { get; set; }
        public int ProviderId { get; set; }
=======
        public int Amount { get; set; }
        public double Weight { get; set; }
        public int CategoryId { get; set; }
        public int ProviderId { get; set; }

        public Product(int id, string name, decimal price, int amount, double weight, int categoryId, int providerId)
        {
            Id = id;
            Price = price;
            Amount = amount;
            Weight = weight;
            CategoryId = categoryId;
            ProviderId = providerId;
        }

>>>>>>> Task4-APILayer
    }
}      