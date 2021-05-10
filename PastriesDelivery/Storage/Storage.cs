using System.Collections.Generic;

namespace PastriesDelivery
{
    public class Storage : IStorage
    {
        public List<StorageType> Type { get; set; }
        public List<Pastry> Pastries { get; set; }
        public List<User> Users { get; set; }

        public Storage()
        {
            Type = new List<StorageType>();
            Pastries = new List<Pastry>();
            Users = new List<User>();
        }
    }
}