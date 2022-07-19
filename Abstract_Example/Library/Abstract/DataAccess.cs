using Abstract_Example.Library.Interface;

namespace Abstract_Example.Library.Abstract
{
    public abstract class DataAccess : IDataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        } 
        public abstract void LoadData(string sql);  
        public abstract void SaveData(string sql);
    } 
}
