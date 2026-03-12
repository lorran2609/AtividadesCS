using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estruturas
{
    internal class Listas
    {
        private List<string> nomes;

        public Listas()
        {
            nomes = new List<string>()
            {
            "Maria",
            "João",
            "Pedro",
            "Paulo"
            };
        }
		public void menu()
		{
			bool continuar = true;
			while (continuar)
			{
				Console.Clear();
				Console.WriteLine("--------------");
				MostrarLista();
				Console.WriteLine("--------------");
				Console.WriteLine("Escolha: ");
				Console.WriteLine("1 - Adicionar Nome");
				Console.WriteLine("2 - Remover pelo Nome");
				Console.WriteLine("3 - Remover pela posição");
				Console.WriteLine("4 - Limpar Lista");
				Console.WriteLine("5 - Ordenar Lista");
				Console.WriteLine("6 - Inverter Nomes");
				Console.WriteLine("7 - Pesquisar Nome");
				Console.WriteLine("8 - Pesquisar Indice");
				Console.WriteLine("Opção: ");
				int op = int.Parse(Console.ReadLine());
				switch (op)
				{
					case 1: AdicionarNome(); break;
					case 2: RemoverNome(); break;
					case 3: RemoverPosicao(); break;
					case 4: LimparLista(); break;
					case 5: OrdenarLista(); break;
					case 6: InverterLista(); break;
					case 7: BuscarNome(); break;
					case 8: BuscarPosicao(); break;

					default: Console.WriteLine("Erro"); ; break;
				}
			}
		}

		private void MostrarLista() 
		{
			foreach (string nome in nomes)
			{
				Console.WriteLine(nome);
			}
		}

		private void AdicionarNome() 
		{
            Console.WriteLine("Digite um nome: ");
			string n = Console.ReadLine();
			nomes.Add(n);
            Console.WriteLine("Nome Adicionado");
		}
		private void RemoverNome()
		{
            Console.WriteLine("Digite o nome que deseja remover: ");
			String n = Console.ReadLine();
			if (nomes.Contains(n))
			{
				nomes.Remove(n);
				Console.WriteLine("Nome Removido");
			}
			else
			{
                Console.WriteLine("Nome não encontrado");
			}
			Console.ReadKey();
		}

		private void RemoverPosicao() 
		{
			int posicao = int.Parse(Console.ReadLine());
			nomes.RemoveAt(posicao);
            Console.WriteLine("Nome Removido!");
			Console.ReadKey();
		}
		private void LimparLista()
		{
			nomes.Clear();
		}
		private void OrdenarLista()
		{
			nomes.Sort();
		}
		private void InverterLista()
		{
			nomes.Reverse();
		}
		private void BuscarNome()
		{
            Console.WriteLine("Digite o nome: ");
			string n = Console.ReadLine();
			if (nomes.Contains(n))
			{
				Console.WriteLine("Esse nome existe na lista");
			}
			else
			{
                Console.WriteLine("Esse nome não está na lista");
			}
			Console.ReadKey();

		}
		private void BuscarPosicao()
		{
			Console.WriteLine("Digite o nome: ");
			string n = Console.ReadLine();
			int posicao = nomes.IndexOf(n);
			if (posicao !=1)
			{
				Console.WriteLine($"{n} Está na posição {posicao}");
			}
			else
			{
				Console.WriteLine("Posição inexistente na lista");
			}
			Console.ReadKey();
		}
	}
}
