using Microsoft.EntityFrameworkCore;
using RentACarProject.Core.DataAccess.EntityFramework;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context=new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
       public List<CarDto> GetCarDto()
        {
            using (CarContext context=new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear
                             };

            return result.ToList();
            }
            
        }
        public  List<CarDto2> GetCarDto2()
        {
            using(CarContext context=new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDto2
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ModelYear= c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}