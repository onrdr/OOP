using Abstract_Example.Library.Abstract; 

namespace Abstract_Example.Library
{
    public class SqliteDataAccess : DataAccess 
    { 
        public override void LoadData(string sqlLite)
        {
            Console.WriteLine($"{sqlLite} ==> Loading SQLite Data"); 
        }

        public override void SaveData(string sqlLite)
        {
            Console.WriteLine($"{sqlLite} ==> Saving data to SQLite");
        }
        
    }
}
