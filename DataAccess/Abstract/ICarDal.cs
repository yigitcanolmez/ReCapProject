using Core.DataAccess;
using Entities;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDTO> GetCarDetail();
    }
}
