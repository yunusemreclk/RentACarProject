using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RentACarProject.Business.Concrete;
using RentACarProject.Core.Utilities.Results;
using RentACarProject.DataAccess.Concrete.EntityFramework;

CarGetAllTest();

static void CarGetAllTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetAll();
    if(result.Success==true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.CarId + "-" + item.ModelYear + "-" +
                          item.Description + "-" + item.DailyPrice);
               
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}
//GetCarDetailsTest();

static void GetCarDetailsTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDetails();
    if (result.Success == true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.CarId + "-" + item.BrandName + "-" +
                               item.ColorName + "-" + item.ModelYear + "-" +
                               item.Description + "-" + item.DailyPrice);

        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
 
}

//GetCarDtoTest();

static void GetCarDtoTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDto();
    if (result.Success == true)
    {
        foreach (var i in result.Data)
        {
            Console.WriteLine(i.CarId + "-" + i.BrandName + "-" +
                               i.ColorName + "-" + i.ModelYear);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
    
    
}
//GetCarDto2();

static void GetCarDto2()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetCarDto2();
    if (result.Success==true)
    {
        foreach (var item in result.Data)
        {
            Console.WriteLine(item.CarId + "-" + item.BrandName + "-" +
                              item.ModelYear + "-" + item.Description);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
  
}