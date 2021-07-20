using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    class Snack
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set;}

        public Snack() { }
        public Snack(int Codice, string Nome, decimal Prezzo)
        {
            this.Codice = Codice;
            this.Nome = Nome;
            this.Prezzo = Prezzo;
        }

    }
}
