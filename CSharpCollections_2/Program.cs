using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criação Variaveis
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            // Criação da Lista
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            // Get the last and first in different ways.
            Console.WriteLine("Get the last and first -------------\n");
            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A última aula é " + aulas[aulas.Count -1]);

            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A última aula é " + aulas.Last());
            Console.WriteLine("\n");

            // Alterando um element da lista
            Console.WriteLine("Alterando elemento da lista -------------\n");
            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);


            // Localizando palavras
            Console.WriteLine("Finding words in list  -------------\n");
            Console.WriteLine("A primeira aula 'Trabalhando' é:" + aulas.First(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A última aula 'Trabalhando' é:" + aulas.Last(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A primeira aula 'Conclusão' é:" + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));
            Console.WriteLine("\n");

            // Reverse
            Console.WriteLine("Reverse -------------\n");
            aulas.Reverse();
            Imprimir(aulas);
            Console.WriteLine("\n");

            // RemoveAt
            Console.WriteLine("RemoveAt -------------\n");
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            // Adicionando aula
            Console.WriteLine("Adicionando aula  -------------\n");
            aulas.Add("Conclusão");
            Imprimir(aulas);

            // Sort
            Console.WriteLine("Sort -------------\n");
            aulas.Sort();
            Imprimir(aulas);

            // Copy Elements
            Console.WriteLine("Copy -------------\n");
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            // Clone
            Console.WriteLine("Clone -------------\n");
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

            Console.WriteLine("\n");
        }
    }
}
