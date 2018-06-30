using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando uma instancia da classe navegador
            var navegador = new Navegador();

            // navegando entre as paginas
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("facebook.com");
            navegador.NavegarPara("devgenius.com.br");

            // retornar ao historico anterior
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            // retornar ao historico proximo
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();

        }
    }

    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                // push adiciona item a pilha
                historicoProximo.Push(atual);

                // Pop retira o item da pilha
                atual = historicoAnterior.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine($"Página atual: {atual}");

        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {atual}");

            }
        }
    }
}
