using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface IStorage
    {
        List<Pastry> Pastries { get; set; }
        StorageType Type { get; set; }
        List<User> Users { get; set; }
    }
}