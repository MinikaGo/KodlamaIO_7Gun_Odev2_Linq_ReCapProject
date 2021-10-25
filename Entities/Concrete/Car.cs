using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : Abstract.ICar
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
