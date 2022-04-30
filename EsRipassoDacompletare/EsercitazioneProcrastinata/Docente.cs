using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneProcrastinata
{
    public class Docente : Persona
    {
        public string Materia { get; set; }
        public bool Laureato { get; set; }

        public Docente(){}

        public Docente(string nom, string cog, string mat, bool lau)
        {
            if (nom != null && nom != "")
            {
                this.Nome = nom;
            }
            else
            {
                throw new ArgumentException("Non puo' essere vuoto");
            }

            if (cog != null && cog != "")
            {
                this.Cognome = cog;
            }
            else
            {
                throw new ArgumentException("Non puo' essere vuoto");
            }

            if (mat != null && mat != "")
            {
                this.Materia = mat;
            }
            else
            {
                throw new ArgumentException("Non puo' essere vuoto");
            }

            this.Laureato = lau;
        }

        public override string ToString()
        {
            return $"{this.Nome} {this.Cognome}-{this.Materia}";
        }

        public override string Saluta()
        {
            return $"Buongiorno studenti";
        }

        public string nome
        {
            get
            {
                return this.Nome;
            }

            set
            {
                this.Nome = value;
            }
        }

        public string cognome
        {
            get
            {
                return this.Cognome;
            }

            set
            {
                this.Cognome = value;
            }
        }
    }
}
