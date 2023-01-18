using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal :IEntityRepository<Car>
    {
        public void GetCarsByBrandId(int brandId);
        public void GetCarsByColorId(int colorId);
    }
}
