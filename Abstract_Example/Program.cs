using Abstract_Example.Library;
using Abstract_Example.Library.Abstract;

/*
    We used abstract class instead of interface because : 
    ==> MSSQL and SQLite has a COMMON method that is LoadConnectionString() and it has the SAME IMPLEMENTATION 
        for both child classes SqlDataAccess and SqliteDataAccess. 
    ==> We still have the ability to override and change the implemenatation of LoadConnectionString() 
        for any of child class whenever we need.
    Hovewer, i still created an interface called IDataAccess for parent class DataAccess since it is the best practice.
 */
List<DataAccess> databases = new()
{
    new SqlDataAccess(),
    new SqliteDataAccess()
};

databases.ForEach(db =>
{
    db.LoadConnectionString("demo");
    db.LoadData("select * from table");
    db.SaveData("insert into table");
    Console.WriteLine("=============================================================");
});  


Console.ReadKey();
