using RentACarProject.Core.Utilities.Results;
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
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult <List<Car>> GetAll();
        IDataResult <List<Car>> GetByCar(int id);
        IDataResult <List<CarDetailDto>> GetCarDetails();
        IDataResult <List<CarDto>> GetCarDto();
        IDataResult <List<CarDto2>> GetCarDto2();
    }
}
