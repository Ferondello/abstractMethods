using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaJuridica.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int Employees { get; set; }

        public PessoaJuridica(string name, double anualRevenue, int employees) : base(name, anualRevenue) 
        { 
            Employees = employees;
        }
        public override double Tax()
        {
            if(Employees > 10)
            {
                return AnualRevenue * 0.14;
            }
            else
            {
                return AnualRevenue * 0.16;
            }
        }
    }
}
