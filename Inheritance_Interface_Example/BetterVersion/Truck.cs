using BetterVersion.Interface;

namespace BetterVersion
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public string RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
