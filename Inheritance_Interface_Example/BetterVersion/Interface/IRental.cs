 namespace BetterVersion.Interface
{
    public interface IRental
    {
        public string RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
