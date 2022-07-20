using BetterVersion.Interface;

namespace BetterVersion
{
    public class BetterVersionProgram
    {
        public static void Run()
        {
            List<IRental> rentals = new()
            {
                new Truck() { CurrentRenter = "Truck Renter" },
                new SailBoat() { CurrentRenter = "SailBoat Renter" },
                new Car() { CurrentRenter = "Car Renter" }
            };

            rentals.ForEach(r => Console.WriteLine($"{r.CurrentRenter}"));
            Console.WriteLine();

            List<LandVehicle> lands = new()
            {
                new Truck(), 
                new Car()
            };

            lands.ForEach(lv => lv.StartEngine()); 
        }
    }
}
