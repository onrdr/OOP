using BetterVersion.Interface;

namespace BetterVersion
{
    public class SailBoat : IRental
    {
        public string RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; } 
    }
}
