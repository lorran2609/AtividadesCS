using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    internal class Vetor
    {
		private string[] nomes;

		public Vetor()
		{
			nomes = new string[10]
			{
				"André",
				"João",
				"Marcos",
				"Carlos",
				"Paula", 
				"Zeca", 
				null,
				null, 
				null, 
				null
			};
		}

		public void menu() 
		{
			bool continuar = true;
			while (continuar)
			{
				Console.Clear();
				Console.WriteLine("--------------");
				MostrarNomes();
                Console.WriteLine("--------------");
				Console.WriteLine("Escolha: ");
                Console.WriteLine("1 - Adicionar Nome");
                Console.WriteLine("2 - Remover pelo Nome");
                Console.WriteLine("3 - Remover pelo Indice");
                Console.WriteLine("4 - Limpar Vetor");
                Console.WriteLine("5 - Ordenar Vetor");
                Console.WriteLine("6 - Inverter Nome");
                Console.WriteLine("7 - Pesquisar Nome");
                Console.WriteLine("8 - Pesquisar Indice");
                Console.WriteLine("Opção: ");
				int op = int.Parse(Console.ReadLine());
				switch (op)
				{
					case 1: AdicionarNome();break;
					case 2: RemoverNome(); break;
					case 3: RemoverIndice(); break;
					case 4: LimparVetor(); break;
					case 5: OrdenarVetor(); break;
					case 6: InverterNome(); break;
					case 7: PesquisarNome(); break;
					case 8: PesquisarIndice(); break;

					default: Console.WriteLine("Erro"); ; break;
				}
			}
		}
		private void MostrarNomes() 
		{
			for (int j = 0; j < nomes.Length; j++)
			{
				if (nomes[j] != null) 
				{
                    Console.WriteLine(j + " - " + nomes[j]);
				}
			}
		}
		private void AdicionarNome()
		{
			int posicaoVazia = Array.IndexOf(nomes, null);

			if (posicaoVazia == -1)
			{
				Console.WriteLine("Vetor Cheio");
				return;
			}
            Console.WriteLine("Digite nome: ");
			try
			{
				nomes[posicaoVazia] = Console.ReadLine();
				Console.WriteLine("Nome Adicionado!");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				throw;
			}
		}
		private void RemoverNome()
		{
            Console.Write("Digite o nome: ");
			string n = Console.ReadLine();
			int posicao = Array.IndexOf(nomes, n);
			if (posicao == -1){
				Console.WriteLine("Não encontrado");
				return;
			}
			try
			{
				nomes[posicao] = null;
				Console.WriteLine("Nome Removido");
			}
			catch (Exception ex)
			{ 
				Console.WriteLine(ex.ToString());
				throw;
			}
		}
		private void RemoverIndice() 
		{
            Console.WriteLine("Digite o Indice para remover: ");
			int posicao = int.Parse(Console.ReadLine());
			try
			{
				nomes[posicao] = null;
				Console.WriteLine("Indice Removido");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				throw;
			}
		}
		private void LimparVetor() 
		{
			try
			{
				Array.Clear(nomes, 0, nomes.Length);
				Console.WriteLine("Vetor Limpo");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				throw;
			}
		}
		private void OrdenarVetor() 
		{
			Array.Sort(nomes);
		}
		private void InverterNome()
		{
			Array.Reverse(nomes);
		}
		private void PesquisarNome() 
		{
            Console.WriteLine("Digite um nome: ");
			string n = Console.ReadLine();
			bool existe = false;
			for (int i = 0;  i < nomes.Length; i++) {
				if (n.Equals(nomes[i]))
				{
					existe = true;
					break;
				}
			}

			if (existe)
			{
				Console.WriteLine("Nome Encontrado");
			}
			else 
			{
                Console.WriteLine("Nome inexistente");
			}
		}
		private void PesquisarIndice()
		{
            Console.WriteLine("Digite o nome para achar o indice: ");
			string n = Console.ReadLine();
			int posicao = Array.IndexOf(nomes, n);

			if (posicao != -1)
			{
				Console.WriteLine($"Encontrado na posição: {posicao}");
			}
			else
			{
				Console.WriteLine("Nome não encontrado");
			}
			Console.ReadKey();
		}
	}
}
