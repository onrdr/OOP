using Interface_Example.Library.Interface;

namespace Interface_Example.Library.Entity
{
    public class Customer : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
