using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Vanzari.Entities
{
    public class Comanda
    {
        private static int _lastId = 0;
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Modalitate { get; set; }
        public int Id_Client { get; set; }
        public int Id_Vanzator { get; set; }
        public List<Produs> Produse { get; set; }

        public Comanda()
        {
            this.Id = ++_lastId;
            Produse = new List<Produs>();
        }
    }
}
