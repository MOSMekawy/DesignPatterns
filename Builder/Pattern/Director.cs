namespace Builder.Pattern
{
    public class Director 
    {
        public Director() { }
        public void ConstructSportsCar(IVehicleBuilder builder)
        {
            builder.reset();
            builder.SetEngineHP(4000);
            builder.SetGasPerMile(4);
            builder.SetSeats(2);
            builder.SetHasGps(true);
        }
    }
}
