using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoPOO_aula2
{
    internal class PessoaFisica : Cliente
    {
        private int tipoCliente;
        private string pacote;
        private double valorPacote = 100;

        public override double CalcularDesconto()
        {
            if (tipoCliente == 1)
            {
                valorPacote = valorPacote - 5;
            }
            else if (tipoCliente == 2)
            {
                valorPacote = valorPacote - 10;
            }
            else
            {
                valorPacote = valorPacote - 20;
            }
            return valorPacote;
        }
		public override void TipoCliente()
        {
            Console.Write("Selecione o tipo de conta: " +
                "\n[1] Universitária \n[2] Essencial \n[3] Prime \n\nSelecione: ");
            tipoCliente = int.Parse(Console.ReadLine());
			Console.Clear();
        }
		public override void ExibirDados()
		{
			if (tipoCliente == 1)
			{
				Console.WriteLine("Tipo: Cliente Universitário");
			}
			else if (tipoCliente == 2)
			{
				Console.WriteLine("Tipo: Cliente Essencial");
			}
			else if (tipoCliente == 3)
			{
				Console.WriteLine("Tipo: Cliente Prime");
			}
			base.ExibirDados();
		}
	}
}
