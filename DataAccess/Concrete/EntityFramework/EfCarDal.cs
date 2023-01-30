using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, EfDbContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetail()
        {
            using (EfDbContext cnt = new EfDbContext())
            {
                var result = from car in cnt.Cars
                             join b in cnt.Brands
                              on car.BrandId equals b.Id
                             join clr in cnt.Colors
                             on car.ColorId equals clr.Id
                             select new CarDetailDTO
                             {
                                 CarId = car.Id,
                                 CarName = car.CarName,
                                 BrandName = b.Name,
                                 ColorName = clr.Name,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (EfDbContext cnt = new EfDbContext())
            {
                var result = cnt.Set<Car>().Where(p => p.BrandId == brandId).ToList();
                return result;
            }
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            using (EfDbContext cnt = new EfDbContext())
            {
                var result = cnt.Set<Car>().Where(p => p.ColorId == colorId).ToList();
                return result;
            }
        }
    }
}

