using System.Security.Cryptography.X509Certificates;

namespace Builder.Pattern
{
    public class CarBuilder : IVehicleBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            reset();
        }

        public void reset()
        {
            _car = new Car();
        }

        public void SetEngineHP(int hp)
        {
            _car.EngineHP = hp;
        }

        public void SetGasPerMile(int gasPerMile)
        {
            _car.GasPerMile = gasPerMile;
        }

        public void SetHasGps(bool hasGps)
        {
            _car.HasGps = hasGps;
        }

        public void SetSeats(int seats)
        {
            _car.Seats = seats;
        }

        public Car GetProduct() => _car;
    }
}
