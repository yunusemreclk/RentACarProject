using RentACarProject.Business.Abstract;
using RentACarProject.Business.BusinessAspects.Autofac;
using RentACarProject.Business.Constants;
using RentACarProject.Business.ValidationRules.FluentValidation;
using RentACarProject.Core.Aspects.Autofac.Caching;
using RentACarProject.Core.Aspects.Autofac.Performance;
using RentACarProject.Core.Aspects.Autofac.Validation;
using RentACarProject.Core.Utilities.Business;
using RentACarProject.Core.Utilities.Results;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;

namespace RentACarProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly IBrandService _brandService;


        public CarManager(ICarDal carDal,IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails(),Messages.CarListed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByCarId(int id)
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
        [SecuredOperation("car.Add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car) 
        {
            //var context = new ValidationContext<Car>(car);
            //CarValidator carValidator = new CarValidator();
            //var result = carValidator.Validate(context);
            //if (!result.IsValid)
            //{
            //{
            //    throw new ValidationException(result.Errors);
            //}

            IResult result = BusinessRules.Run(
                CheckIfBrandLimitedExceded());
            _carDal.Add(car);
            return new SuccessResult("Araç eklendi");
        }
        [SecuredOperation("car.delete,admin")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araç silindi");
        }
        [SecuredOperation("car.Update,admin")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Araç güncellendi");
        }
        private IResult CheckIfBrandLimitedExceded()
        {
            var result = _brandService.GetAll();
            if(result.Data.Count>15)
            {
                return new ErrorResult(Messages.BrandLimitExceded);
            }
            return new SuccessResult();
        }

        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }
            Add(car);

            return null;
        }
    }


}

