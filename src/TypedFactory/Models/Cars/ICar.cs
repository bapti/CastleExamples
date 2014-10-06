using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypedFactory.Models
{
    public interface ICar
    {
        string ModelName { get; set; }
        string OwnerName { get; set; }
    }
}
