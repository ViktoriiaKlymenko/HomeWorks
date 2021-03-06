namespace PastriesDelivery
{
    /// <summary>
    /// This class contains consumer's main information to embody b2c deals.
    /// </summary>
    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
    }
}