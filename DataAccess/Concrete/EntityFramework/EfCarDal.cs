using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
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
        public void GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}

