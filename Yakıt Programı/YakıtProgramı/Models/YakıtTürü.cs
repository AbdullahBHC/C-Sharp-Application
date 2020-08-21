using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakıtProgramı.Models
{
   public class YakıtTürü
    {
        public string YakıtTürüAdı { get; set; }
        public int YakıtLitre { get; set; }

        public override string ToString() => $"{YakıtTürüAdı}";
     
    }
}
