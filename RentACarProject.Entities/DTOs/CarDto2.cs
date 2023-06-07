using RentACarProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarProject.Entities.DTOs
{
  public class CarDto2:IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public short ModelYear { get; set; }
        public string Description { get; set; }
    }
}
