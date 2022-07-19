 
namespace Abstract_Example.Library.Interface
{
    public interface IDataAccess
    { 
        void LoadData(string sql);
        void SaveData(string sql);
    }
}
