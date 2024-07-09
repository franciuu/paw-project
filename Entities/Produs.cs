using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vanzari.Entities
{
    public class Produs
    {
        public int Id { get; set; }
        public String Denumire { get; set; }
        public String Descriere { get; set; }
        public double Pret { get; set; }
        public int Stoc { get; set; }

    }
}
