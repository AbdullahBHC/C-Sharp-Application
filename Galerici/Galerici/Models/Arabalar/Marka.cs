using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galerici.Models
{
    public class Marka
    {
        public string MarkaAdı { get; set; }
        public override string ToString()
        {
            return MarkaAdı;
        }
    }
}
