using Microsoft.AspNetCore.Http;
using RentACarProject.Business.Abstract;
using RentACarProject.Business.Constants;
using RentACarProject.Core.Utilities.Business;
using RentACarProject.Core.Utilities.Helpers.FileHelp;
using RentACarProject.Core.Utilities.Results;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace RentACarProject.Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;
        private readonly IFileHelper _fileHelper;
        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(
            CheckIfCarImageLimit(carImage.CarId)
            );

            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImagesAdded); 

        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(x=>x.Id==id));
        }

        public IDataResult<List<CarImage>> GetByImageCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(x => x.CarId == carId));
        }

        public IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarId = carId, ImagePath = "defaultImage.jpg" });
            return new SuccessDataResult<List<CarImage>>(carImage);

        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            _fileHelper.Update(file, PathConstants.ImagesPath + carImage.ImagePath,carImage.ImagePath);
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdate);
        }
        private IResult CheckIfCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId).Count;
            if (result>=5 )
            {
                return new ErrorResult(Messages.CarImagesLimitedExceded);
            }
            return new SuccessResult();
        }


    }
}
