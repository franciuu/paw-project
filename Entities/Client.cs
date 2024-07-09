using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vanzari.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public String Nume { get; set; } 
        public String Prenume { get; set; }
        public DateTime DataNastere { get; set; }
        public String Email { get; set; }
        public String Telefon { get; set; }
    }
}
