using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypedFactory.Models
{
    public class Fiat : ICar
    {
        public string ModelName { get; set; }
        public string OwnerName { get; set; }
    }
}
