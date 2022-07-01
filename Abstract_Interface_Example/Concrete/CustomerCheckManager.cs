using Abstract; 

namespace Concrete
{
    internal class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(IEntity person)
        { 
            if (person == null || person.FirstName.StartsWith('O'))
                return false;
            else
                return true;
        }
    }
}
