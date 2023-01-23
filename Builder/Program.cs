using Builder.Pattern;

var carBuilder = new CarBuilder();
var carManualBuilder = new CarManualBuilder();  

var director = new Director();

director.ConstructSportsCar(carBuilder);
var car = carBuilder.GetProduct();

Console.WriteLine(car.FuelForTrip(80));

director.ConstructSportsCar(carManualBuilder);
var manual = carManualBuilder.GetProduct();

manual.PrintManual();
