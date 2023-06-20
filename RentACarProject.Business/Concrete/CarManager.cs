using RentACarProject.Business.Abstract;
using RentACarProject.Business.Constants;
using RentACarProject.Core.Utilities.Results;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByCar(int id)
        {
         
         return new SuccessDataResult<List<Car>>( _carDal.GetAll(x=>x.CarId== id),Messages.CarListed);
        }

        public IDataResult<List<CarDto>> GetCarDto()
        {
            return new SuccessDataResult<List<CarDto>>( _carDal.GetCarDto());
        }

        public IDataResult<List<CarDto2>> GetCarDto2()
        {
            return new SuccessDataResult<List<CarDto2>>(_carDal.GetCarDto2());
        }

        public IResult Add(Car car)
        {
        
            _carDal.Add(car);
            return new SuccessResult("Araç eklendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araç silindi");
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Araç güncellendi");
        }
    }
}
