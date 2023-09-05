using RentACarProject.Core.DataAccess.EntityFramework;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,CarContext>,ICarImageDal
    {
    }
}
