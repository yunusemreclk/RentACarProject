using RentACarProject.Core.DataAccess;
using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDto> GetCarDto();
        List<CarDto2> GetCarDto2();

    }
}
