using Abstract;
using Concrete;
using Entities;
using Adapters;
 
/*
                             SCENARIO                    

 * We want to build a system that make customer management 

 * We have two banks : Garanti and IsBank
 
 * Both Banks want to save their new customers to their databases 
 
 * IsBank also wants to validate the customer from Government Database (MERNIS) 
 
 */


// Creating customer managers for both banks : 

BaseCustomerManager isCustomerManager = new IsBankCustomerManager(new MernisServiceAdapter());

BaseCustomerManager garantiCustomerManager = new GarantiCustomerManager();


// Some customer examples are added to the banks' databases : 

isCustomerManager.SaveToDatabase(new EngineerCustomer()
{
    DateOfBirth = new DateTime(1987, 9, 14),
    FirstName = "FirstName1",
    LastName = "Last Name1",
    NationalityId = "Enter NationalityId Here"
});

garantiCustomerManager.SaveToDatabase(new TeacherCustomer()
{
    DateOfBirth = new DateTime(1987, 9, 14),
    FirstName = "FirstName2",
    LastName = "Last Name1",
    NationalityId = "Enter NationalityId Here"
});

isCustomerManager.SaveToDatabase(new DoctorCustomer()
{
    DateOfBirth = new DateTime(1987, 9, 14),
    FirstName = "FirstName3",
    LastName = "Last Name3",
    NationalityId = "Enter NationalityId Here"
});

 


Console.ReadKey();
