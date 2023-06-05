﻿using RentACarProject.Business.Abstract;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByCar(int id)
        {
         return _carDal.GetAll(x=>x.Id== id);
        }
    }
}