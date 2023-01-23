namespace Builder.Pattern
{
    public class CarManualBuilder : IVehicleBuilder
    {
        private Manual _carManual;

        public CarManualBuilder()
        {
            reset();
        }

        public void reset()
        {
            _carManual = new Manual();
        }

        public void SetEngineHP(int hp)
        {
            _carManual.EngineHP = hp;
        }

        public void SetGasPerMile(int gasPerMile)
        {
            _carManual.GasPerMile = gasPerMile;
        }

        public void SetHasGps(bool hasGps)
        {
            _carManual.HasGps = hasGps;
        }

        public void SetSeats(int seats)
        {
            _carManual.Seats = seats;
        }

        public Manual GetProduct() => _carManual;
    }
}
