using Interface_Example.Library;
using Interface_Example.Library.Entity;
using Interface_Example.Library.Interface;
{

    List<IProduct> cart = AddSampleData();
    Customer customer = GetCustomer();

    foreach (var product in cart)
    {
        Console.WriteLine("==========================================================");
        product.DeliverItem(customer);

        if (product is IDigitalProduct digital)
            Console.WriteLine($"For the {digital.Title}, you have {digital.TotalDownloadLeft} downloads left");
    }


    Console.ReadKey();


    static Customer GetCustomer()
    {
        return new Customer
        {
            FirstName = "Onur",
            LastName = "Derman",
            City = "Istanbul",
            EmailAdress = "onrdrmn@gmail.com",
            PhoneNumber = "0-111-2222-333"
        };
    }

    static List<IProduct> AddSampleData()
    {
        List<IProduct> output = new()
        {
            new PhysicalProduct { Title = "\"Kobe Bryant T-Shirt\"" },
            new PhysicalProduct { Title = "\"Boeing 737 maquette\"" },
            new PhysicalProduct { Title = "\"Asus Computer\"" },
            new DigitalProduct { Title = "\"Harvard CS50\""},
            new ServiceProduct { Title = "\"Car Rental Service Phone Number\""},  
        };

        return output;
    }
}
