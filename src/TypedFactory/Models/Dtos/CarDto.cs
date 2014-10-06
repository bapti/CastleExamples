using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypedFactory.Models.Dtos
{
    public class CarDto
    {
        public string OwnerName { get; set; }
        public string ModelName { get; set; }
        public CarType CarType { get; set; }
    }

    public enum CarType
    {
        Audi,
        Ferrari,
        Fiat
    }
}
