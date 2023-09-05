using Microsoft.AspNetCore.Mvc;
using RentACarProject.Business.Abstract;
using RentACarProject.DataAccess.Abstract;
using RentACarProject.Entities.Concrete;

namespace RentACarProject.WebAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class CarImagesController : Controller
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;

        }
        [HttpPost("Add")]
        public IActionResult Add(IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(file, carImage);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var carDeleteImage = _carImageService.GetById(carImage.Id).Data;
            var result = _carImageService.Delete(carDeleteImage);
            if (result.Success)

            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
