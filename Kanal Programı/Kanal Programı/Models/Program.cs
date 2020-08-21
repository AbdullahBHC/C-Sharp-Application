using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanal_Programı.Models
{
    public class Program
    {
        public Kanal Kanal { get; set; }
        public string ProgramAdı { get; set; }
        public DateTime Zaman { get; set; }
        public int Süre { get; set; }

        public override string ToString() => ProgramAdı;
       
    }
}
