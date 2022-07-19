using Abstract_Example.Library.Abstract;

namespace Abstract_Example.Library
{
    public class SqlDataAccess : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine($"{sql} ==> Loading Microsoft SQL Data"); 
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine($"{sql} ==> Saving data to Microsoft SQL Server"); 
        }
    }
}
