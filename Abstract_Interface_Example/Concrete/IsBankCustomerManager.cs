using Abstract; 

namespace Concrete
{
    public class IsBankCustomerManager : BaseCustomerManager
    {
        private readonly ICustomerCheckService _customerCheckService;
        public IsBankCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void SaveToDatabase(IEntity customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
                base.SaveToDatabase(customer);
            else
                Console.WriteLine("Not a valid person"); 
        }  

    }
}
