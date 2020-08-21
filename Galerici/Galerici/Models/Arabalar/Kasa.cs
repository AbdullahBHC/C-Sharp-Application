using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galerici.Models
{
    public class Kasa
    {
        public string KasaTipi { get; set; }

        public override string ToString() => KasaTipi;
    }
}
