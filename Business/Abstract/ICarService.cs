using Core.Utilities.Result;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal minPrice, decimal maxPrice);
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDTO>> GetCarDetail();
    }
}
