using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoPOO_aula2
{
    internal class PessoaJuridica : Cliente
    {
        private int tipoCliente;
        private double valorPacote = 100;

        public override double CalcularDesconto()
        {
            valorPacote = valorPacote - 50;
            return valorPacote;
        }

        public override void TipoCliente()
        {
            tipoCliente = 5;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("Tipo: Cliente Pessoa Juridica");
            base.ExibirDados();
        }

    }
}
