using RentACarProject.Core.Utilities.Results;
using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;

namespace RentACarProject.Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult <List<Car>> GetAll();
        IDataResult <List<Car>> GetByCarId(int id);
        IDataResult <List<CarDetailDto>> GetCarDetails();
        IDataResult <List<CarDto>> GetCarDto();
        IDataResult <List<CarDto2>> GetCarDto2();

        IResult AddTransactionalTest(Car car);
    }
}
