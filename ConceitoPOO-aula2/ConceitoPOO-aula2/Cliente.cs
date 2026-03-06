using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoPOO_aula2
{
    abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }

        public abstract void TipoCliente();
        public abstract double CalcularDesconto();
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Código: {Codigo}");
			Console.WriteLine($"Nome: {Nome}");
			Console.WriteLine($"Documento: {Documento}");
            Console.WriteLine($"Valor final do pacote: {CalcularDesconto()}");
		}

    }
}
