using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car
                {
                    Id =1,
                    BrandId = 1,
                    ColorId =1,
                    ModelYear = 2020,
                    DailyPrice = 150000,
                    Description="Kur'an'ıma mükemmel araba"
                }, new Car
                {
                    Id =2,
                    BrandId = 1,
                    ColorId =2,
                    ModelYear = 2022,
                    DailyPrice = 190000,
                    Description="Kur'an'ıma mükemmel arabadır kaçmaz ha"
                }, new Car
                {
                    Id =3,
                    BrandId = 2,
                    ColorId =1,
                    ModelYear = 2018,
                    DailyPrice = 110000,
                    Description="klas geçici kalite kalıcıdr"
                }, new Car
                {
                    Id =4,
                    BrandId = 1,
                    ColorId =1,
                    ModelYear = 2022,
                    DailyPrice = 250000,
                    Description="Kur'an'ıma hepsinden iyidir ha"
                }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car toDelete = _cars.Find(x => x.Id == car.Id);
            _cars.Remove(toDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(x => x.Id == carId).ToList();
        }

        public List<CarDetailDTO> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car toUpdate = _cars.Find(x=>x.Id == car.Id);
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.ModelYear = car.ModelYear;
            toUpdate.BrandId = car.BrandId;
            toUpdate.ColorId = car.ColorId;
            toUpdate.Description = car.Description;
        }

        List<Car> ICarDal.GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarDal.GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
