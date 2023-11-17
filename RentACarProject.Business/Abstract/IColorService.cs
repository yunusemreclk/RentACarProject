using RentACarProject.Core.Utilities.Results;
using RentACarProject.Entities.Concrete;

namespace RentACarProject.Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int id);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);

    }
}
