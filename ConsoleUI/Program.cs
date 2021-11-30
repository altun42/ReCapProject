// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());





//foreach (var car in carManager.GetCarDetails())
//{
//    Console.WriteLine(car.CarName + "/" + car.BrandName);


//}


Car car = new Car();
car.Id = 1;
car.CarName = "Ford Connect";
car.ColorId = 1;
car.DailyPrice = 100;
car.Description = "Manuel";


carManager.Update(car);



//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.BrandName);

//}

