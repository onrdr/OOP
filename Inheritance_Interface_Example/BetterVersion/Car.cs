using BetterVersion.Interface;

namespace BetterVersion
{
    public class Car : LandVehicle, IRental
    {
        public CarType Style { get; set; }
        public string RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
