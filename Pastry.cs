using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Contains all methods for working with a pastry delivery service.
    /// </summary>
    public class Pastry
    {
        private Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public string[] Consist { get; set; }
        public decimal Price { get; set; }
        public string[] Feedbacks { get; set; }
    }

}
