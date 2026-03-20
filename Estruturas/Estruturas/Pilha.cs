using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estruturas
{
    internal class Pilha
    {
        private Stack<string> pilha;
        public Pilha()
        {
            pilha = new Stack<string>();
            pilha.Push("Pedido 1");
			pilha.Push("Pedido 2");
			pilha.Push("Pedido 3");
		}

		public void menu()
		{
			bool continuar = true;
			while (continuar)
			{
				Console.Clear();
				Console.WriteLine("--------------");
				MostrarPilha();
				Console.WriteLine("--------------");
				Console.WriteLine("Escolha: ");
				Console.WriteLine("1 - Adicionar Pedido (PUSH)");
				Console.WriteLine("2 - Remover Pedido (POP)");
				Console.WriteLine("3 - Mostrar Pedido do Topo (PEEK)");
				Console.WriteLine("4 - BUscar Pedido (CONTAINS)");
				Console.WriteLine("5 - Limpar Pilha (CLEAR)");
				Console.Write("\nOpção: ");
				int op = int.Parse(Console.ReadLine());
				switch (op)
				{
					case 1: PushItem(); break;
					case 2: PopItem(); break;
					case 3: PeekItem(); break;
					case 4: ContainsItem(); break;
					case 5: ClearItem(); break;

					default: Console.WriteLine("Erro"); ; break;
				}
			}
		}

		private void MostrarPilha() 
		{
			if (pilha.Count == 0)
			{
                Console.WriteLine("Pilha vazia!");
				return;
			}

			foreach (string item in pilha) 
			{
				Console.WriteLine(item);
			}
		}

		private void PushItem() 
		{
            Console.WriteLine("Digite um pedido: ");
			string pedido = Console.ReadLine();
			pilha.Push(pedido);
		}

		private void PopItem() //LIFO - Last In First Out
		{
			if (pilha.Count > 0)
			{
				string removido = pilha.Pop();
                Console.WriteLine($"{removido} foi retirado da pilha");
			}
			else
			{
                Console.WriteLine("Pilha está vazia!");
			}
		}

		private void PeekItem()
		{
			if (pilha.Count > 0)
			{
				string pedido = pilha.Peek();
                Console.WriteLine($"O item do topo é: {pedido}");
			}
			else
			{
                Console.WriteLine("Pilha está vazia!");
			}
		}

		private void ContainsItem()
		{
            Console.WriteLine("Digite um pedido: ");
			string pedido = Console.ReadLine();

			if (pilha.Contains(pedido))
			{
                Console.WriteLine("O Item estpa na pilha");
			}
			else
			{
                Console.WriteLine("O item não está na pilha");
			}
		}

		private void ClearItem()
		{
			pilha.Clear();
		}
	}
}
