using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarService carService = new CarService(new EfCarDal());

//foreach (var item in carService.GetAll().Data)
//{
//    Console.WriteLine(item.Id + " " + item.BrandId + " " + item.ColorId + " " + item.ModelYear + " " + item.DailyPrice + " " + item.Description);
//}
var result = carService.GetCarDetail();
foreach (var item in result.Data)
{

    Console.WriteLine(item.CarId + " " + item.BrandName + " " + item.CarName + " " + item.ColorName + " " + item.DailyPrice.ToString("0.##"));
}