using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneProcrastinata
{
    public abstract class Persona
    {
        public string Nome { get; set; } 
        public string Cognome{ get; set; }

        public Persona() {}

        public override string ToString()
        {
            return $"Nome: {this.Nome}, Cognome: {this.Cognome}";
        }

        public abstract string Saluta();
    }
}
