namespace Builder.Pattern
{
    public class Car
    {
        public int EngineHP { get; set; }
        public int GasPerMile { get; set; }
        public int Seats { get; set; }
        public bool HasGps { get; set; }

        public int FuelForTrip(int numOfMiles)
        {
            // liters of fuels needed
            return numOfMiles * GasPerMile;
        }
    }
}
