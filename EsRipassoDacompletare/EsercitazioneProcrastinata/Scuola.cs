using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneProcrastinata
{
    public class Scuola
    {
        public string Indirizzo { get; set; }

        public List<Persona> DoceStud = new List<Persona>();

        public Scuola() { }
        public Scuola(string Ind)
        {
            this.Indirizzo = Ind;
        }
    }
}
