using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoPOO_aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.Codigo = 123;
            pf.Nome = "Jimmy Neutron do IFES";
            pf.Documento = "171171";
            pf.TipoCliente();
            pf.ExibirDados();

            Console.WriteLine("\n################################\n");

            PessoaJuridica pj = new PessoaJuridica();
            pj.Codigo = 500;
            pj.Nome = "Atirador Misael";
            pj.Documento = "00000000";
            pj.ExibirDados();
            Console.ReadLine();
        }
    }
}
