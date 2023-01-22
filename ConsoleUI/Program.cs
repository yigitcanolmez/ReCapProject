using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

CarService carService = new CarService(new InMemoryCarDal());

//foreach (var item in carService.GetAll().Data)
//{
//    Console.WriteLine(item.Id + " " + item.BrandId + " " + item.ColorId + " " + item.ModelYear + " " + item.DailyPrice + " " + item.Description);
//}

var result = carService.GetAllByBrandId