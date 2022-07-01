using Abstract;

namespace Entities
{
    public class TeacherCustomer : BaseCustomer, IEntity
    {
        public TeacherCustomer()
        {
            JobTitle = "Teacher"
;        }
    }
}
