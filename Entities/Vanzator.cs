using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vanzari.Entities
{
    public class Vanzator
    {   public int Id { get; set; }
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public DateTime DataNasterii { get; set; }
        public String Telefon { get; set; }
        public double Salariu { get; set; }
        public String Sex { get; set; }
    }
}
