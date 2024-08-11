using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaJuridica.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double AnualRevenue { get; set; }

        public Pessoa() { }

        protected Pessoa(string name, double anualRevenue)
        {
            Name = name;
            AnualRevenue = anualRevenue;
        }
        public abstract double Tax();
    }
}
