using PessoaFisicaJuridica.Entities;

namespace PessoaFisicaJuridica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            
            Console.Write("Numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informacoes do comtribuinte #{i} : ")
                    ;
                Console.Write("Pessoa juridica ou fisica (j/f)");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Renda anual: ");
                double annualRevenue = double.Parse(Console.ReadLine());
                
                if(op == 'f')
                {
                    Console.Write("Gastos com saude: ");
                    double healthSpendings = double.Parse(Console.ReadLine());

                    list.Add( new PessoaFisica(name, annualRevenue, healthSpendings));
                }
                else
                {
                    Console.Write("Numero de funcionarios: ");
                    int employess = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(name, annualRevenue, employess));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Impostos pagos: ");
            double sum = 0;
            foreach(Pessoa pessoa in list)
            {
                sum += pessoa.Tax();
                Console.WriteLine(pessoa.Name + ": $" + pessoa.Tax().ToString("F2"));

            }
            Console.WriteLine("Total taxes: $" + sum.ToString("F2"));
        }
    }
}
