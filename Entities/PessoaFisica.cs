using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaJuridica.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double HealthSpendings   { get; set; }

        public PessoaFisica(string name, double anualRevenue, double healthSpendings) : base(name, anualRevenue)
        {
            HealthSpendings = healthSpendings;
        }
        public override double Tax()
        {
           
            if(AnualRevenue < 20000)
            {
                return AnualRevenue * 0.15  - (0.5 * HealthSpendings); 
            }
            else
            {
                return AnualRevenue * 0.25 - (0.5 * HealthSpendings);
            }
        }
    }
}
