using RentACarProject.Business.Concrete;
using RentACarProject.DataAccess.Concrete.InMemory;

CarManager carManager=new CarManager(new InMemoryCarDal());
foreach (var item in carManager.GetAll())
{
    Console.WriteLine(item.ModelYear);
}