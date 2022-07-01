using Abstract;

namespace Entities
{
    public class DoctorCustomer : BaseCustomer, IEntity
    {
        public DoctorCustomer()
        {
            JobTitle = "Doctor";
        }
    }
}
