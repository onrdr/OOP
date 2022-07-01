
namespace Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    { 
        public virtual void SaveToDatabase(IEntity person)
        {
            Console.WriteLine($"{person.JobTitle} {person.FirstName} has been registered to {this.GetType().Name} Database");
        } 
    }
}
