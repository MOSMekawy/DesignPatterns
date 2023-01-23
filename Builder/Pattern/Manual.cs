namespace Builder.Pattern
{
    public class Manual
    {
        public int EngineHP { get; set; }
        public int GasPerMile { get; set; }
        public int Seats { get; set; }
        public bool HasGps { get; set; }
        public void PrintManual()
        {
            var gpsStatement = HasGps ? "has" : "does not have";

            var manual = @$"
                This car has {EngineHP} Horse Power. 
                The fuel consumption is {GasPerMile} per mile.
                This car has {Seats} seats.
                The car {gpsStatement} gps.
            ";

            Console.Write(manual);
        }
    }
}
