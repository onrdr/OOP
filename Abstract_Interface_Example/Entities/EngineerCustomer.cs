using Abstract;

namespace Entities
{
    public class EngineerCustomer : BaseCustomer, IEntity
    {
        public EngineerCustomer()
        {
            JobTitle = "Engineer";
        }
    }
}
