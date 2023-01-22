using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
    public interface ICarDal :IEntityRepository<Car>
    {
        public void GetCarsByBrandId(int brandId);
        public void GetCarsByColorId(int colorId);
    }
}
