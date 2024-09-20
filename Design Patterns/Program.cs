using Design_Patterns.Abstract_Factory.Factories;
using Design_Patterns.Abstract_Factory;
using Design_Patterns.Factory;
using Design_Patterns.Singleton;


// Singletion 

var globalMood = MoodManager.GetInstance("Happy!");
Console.WriteLine(globalMood.Mood);

var localMood = MoodManager.GetInstance("Neutral");
Console.WriteLine(localMood.Mood); // Still Happy!


// Factory

var myCar = VehicleFactory.CreateVehicle("car");
myCar.Drive();

var myBike = VehicleFactory.CreateVehicle("bike");
myBike.Drive();

var myTruck = VehicleFactory.CreateVehicle("truck");
myTruck.Drive();


// Abstract Factory

IDeliveryEmployeeFactory shipDeliveryFactory = new TruckDeliveryFactory();
IDriver shipCapitan = shipDeliveryFactory.CreateDriver();
IVehicle  shipVehicle = shipDeliveryFactory.CreateVehicle();

Console.WriteLine(shipCapitan.GetLicenseInfo());
Console.WriteLine(shipVehicle.GetVehicleInfo());


IDeliveryEmployeeFactory truckDeliveryFactory = new ShipDeliveryFactory();
IDriver truckDriver = truckDeliveryFactory.CreateDriver();
IVehicle truckVehicle = truckDeliveryFactory.CreateVehicle();

Console.WriteLine(truckDriver.GetLicenseInfo());
Console.WriteLine(truckVehicle.GetVehicleInfo());