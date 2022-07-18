using Interface_Example.Library.Entity;
using Interface_Example.Library.Interface;

namespace Interface_Example.Library
{
    public class PhysicalProduct : IProduct
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }
        public void DeliverItem(Customer customer)
        {
            if (!HasOrderBeenCompleted)
                Console.WriteLine($"Shipping {Title} to {customer.FirstName} {customer.LastName} in {customer.City}");

            HasOrderBeenCompleted = true;
        }
    }
}


