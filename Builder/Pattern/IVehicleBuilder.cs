namespace Builder.Pattern
{
    public interface IVehicleBuilder
    {
        public void reset();
        public void SetEngineHP(int hp);
        public void SetGasPerMile(int gasPerMile);
        public void SetSeats(int seats);
        public void SetHasGps(bool hasGps);
    }
}
