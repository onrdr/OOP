
using Interface_Example.Library.Entity;
using Interface_Example.Library.Interface;

namespace Interface_Example.Library
{
    public class DigitalProduct : IDigitalProduct
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; } 
        public int TotalDownloadLeft { get; private set; } = 21;

        public void DeliverItem(Customer customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Emailing {Title} to {customer.EmailAdress}");
                TotalDownloadLeft--;

                if (TotalDownloadLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadLeft = 0;
                }
            }
        }
    }
}
