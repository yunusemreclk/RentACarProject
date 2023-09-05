using RentACarProject.Core.Utilities.Results;
using RentACarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Business.Abstract
{
    public interface IBrandService
    {
        IDataResult <List<Brand>> GetAll();
        IDataResult<Brand> GetByBrandId(int id);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);


    }
}
