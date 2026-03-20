using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> Lista = new List<Pedido>();

            for (int i = 0; i < 3; i++)
            {
                Pedido p = new Pedido();
                Console.WriteLine("Digite o código da compra:");
                p.Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do cliente:");
                p.NomeCliente = Console.ReadLine();
                Console.WriteLine("Digite o nome do produto:");
                p.Produto = Console.ReadLine();
                Lista.Add(p);
                Console.Clear();
			}

            foreach (var item in Lista)
            {
                Console.WriteLine($"- Codigo: {item.Codigo}\n" +
                    $"- Cliente: {item.NomeCliente}\n" +
                    $"- Produto: {item.Produto}\n\n");
			}
        }
    }
}
