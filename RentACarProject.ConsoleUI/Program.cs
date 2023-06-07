using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RentACarProject.Business.Concrete;
using RentACarProject.DataAccess.Concrete.EntityFramework;

//CarGetAllTest();

static void CarGetAllTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetAll())
    {
        Console.WriteLine(item.CarId);
    }
}
//GetCarDetailsTest();

static void GetCarDetailsTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetCarDetails())
    {
        Console.WriteLine(item.CarId + "-" + item.BrandName + "-" +
                          item.ColorName + "-" + item.ModelYear + "-" +
                          item.Description + "-" + item.DailyPrice);

    }
}

//GetCarDtoTest();

//static void GetCarDtoTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var i in carManager.GetCarDto())
    {
        Console.WriteLine(i.CarId + "-" + i.BrandName + "-" +
                           i.ColorName + "-" + i.ModelYear);

    }
}
GetCarDto2();

static void GetCarDto2()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetCarDto2())
    {
        Console.WriteLine(item.CarId + "-" + item.BrandName + "-" +
                          item.ModelYear + "-" + item.Description);
    }
}