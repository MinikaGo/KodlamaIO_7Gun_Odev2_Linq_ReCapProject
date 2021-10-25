using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public interface ICar
    {
        int Id { get; set; }
        int BrandId { get; set; }
        int ColorId { get; set; }
        short ModelYear { get; set; }
        double DailyPrice { get; set; }
        string Description { get; set; }
    }

}
