using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneProcrastinata
{
    public class Studente: Persona
    {
        public string Classe { get; set; }
        public bool Stage { get; set; }
        List<string> hobby = new List<string>();
        public Studente() { }
        public Studente(string nom, string cog, string cla, bool sta)
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

            if (cla != null && cla != "")
            {
                this.Classe = cla;
            }
            else
            {
                throw new ArgumentException("Non puo' essere vuoto");
            }

            this.Stage = sta;
        }

        public override string Saluta()
        {
            return $"Buongiorno prof !";
        }

        public override string ToString()
        {
            if (this.Stage == true)
            {
                return $"{this.Nome} {this.Cognome}-{this.Classe}-In stage";
            }
            else
            {
                return $"{this.Nome} {this.Cognome}-{this.Classe}-Non in stage";
            }
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
