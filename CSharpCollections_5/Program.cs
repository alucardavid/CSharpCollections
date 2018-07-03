using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_5
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            //entrou: van
            Enfileirar("van");

            //entrou: guincho
            Enfileirar("guincho");

            //entrou: pickup
            Enfileirar("pickup");

            Desenfileirar();

        }

        private static void Desenfileirar()
        {
            // peek serve para ver o proximo a sair da fila

            if (pedagio.Peek() == "guincho")
            {
                Console.WriteLine("guincho está fazendo o pagamento");
            }

            // dequeue serve para tirar o proximo da fila
            string veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}");
            ImprimirFila();
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            // enqueue serve para incluir o item na fila
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");
        }
    }
    
}
