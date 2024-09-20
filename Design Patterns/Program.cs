using Design_Patterns.Abstract_Factory.Factories;
using Design_Patterns.Abstract_Factory;
using Design_Patterns.Factory;
using Design_Patterns.Singleton;
using Design_Patterns.Adapter;
using Design_Patterns.Repository;


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


// Adapter

var squareHole = new SquareHole(5);
var square = new Square(4);

Console.WriteLine(squareHole.canFit(square));

var circle = new Circle(2);
var adaptedCircle = new CircleToSquareAdapter(circle);
Console.WriteLine(squareHole.canFit(adaptedCircle));


// Repository

IProductRepository productRepository = new ProductRepository();
ProductService productService = new ProductService(productRepository);

var laptop = new Product { Id = 1, Name = "Laptop", Price = 999.99m };
var phone = new Product { Id = 2, Name = "Phone", Price = 399.99m };
productService.AddProduct(laptop);
productService.AddProduct(phone);
var updatedPhone = new Product { Id = 2, Name = "Phone on Promo", Price = 299.99m };
productService.UpdateProduct(updatedPhone);
productService.DeleteProduct(laptop.Id);

var products = productService.GetProducts();
foreach (var product in products)
{
    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
}