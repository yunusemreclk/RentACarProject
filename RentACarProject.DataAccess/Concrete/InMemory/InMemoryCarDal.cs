﻿using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
using RentACarProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
         new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 500000, Description = "Perfect Desing", ModelYear = 2022 },
         new Car { CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 600000, Description = "Perfect Desing", ModelYear = 2023 },
         new Car { CarId = 3, BrandId = 1, ColorId = 1, DailyPrice = 400000, Description = "Perfect Desing", ModelYear = 2023 },
         new Car { CarId = 4, BrandId = 3, ColorId = 2, DailyPrice = 550000, Description = "Perfect Desing", ModelYear = 2021 },
        };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(x => x.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDto> GetCarDto()
        {
            throw new NotImplementedException();
        }

        public List<CarDto2> GetCarDto2()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
