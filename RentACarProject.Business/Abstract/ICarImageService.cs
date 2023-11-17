
using Microsoft.AspNetCore.Http;
using RentACarProject.Core.Utilities.Results;
using RentACarProject.Entities.Concrete;

namespace RentACarProject.Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByImageCarId(int carId);
        IDataResult <List<CarImage>> GetDefaultImage(int carId);


    }
}
