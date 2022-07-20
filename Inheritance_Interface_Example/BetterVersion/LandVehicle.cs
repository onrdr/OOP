namespace BetterVersion
{
    public class LandVehicle
    { 
        public int NumberOfPassengers { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("Turn key to ignition settings");
            Console.WriteLine($"Turn key to on. {GetType().Name} is starting");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Turn key to off. {GetType().Name} is closing"); 
        }
    }
}
