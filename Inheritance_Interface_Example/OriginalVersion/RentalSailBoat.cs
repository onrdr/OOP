namespace OriginalVersion
{
    public class RentalSailBoat : RentalVehicle
    {
        public override void StartEngine()
        {
            throw new Exception("This vehicle doesn't have an engine to start");
        }

        public override void StopEngine()
        {
            throw new Exception("This vehicle doesn't have an engine to stop");
        }
    }
}
