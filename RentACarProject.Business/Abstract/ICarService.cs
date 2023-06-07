using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByCar(int id);
        List<CarDetailDto> GetCarDetails();
        List<CarDto> GetCarDto();
        List<CarDto2> GetCarDto2();
    }
}
