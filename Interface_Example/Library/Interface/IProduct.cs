using Interface_Example.Library.Entity;

namespace Interface_Example.Library.Interface
{
    public interface IProduct
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }
        void DeliverItem(Customer customer);
    }
}
