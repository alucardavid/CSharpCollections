using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução ás Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);

            Imprimir(aulas);

            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length -1]);

            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            Console.WriteLine("\nAula modelando está no indice " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));
            Console.WriteLine("\n");

            // Reverse
            Console.WriteLine("Reverse -------------\n");
            Array.Reverse(aulas);
            Imprimir(aulas);
            Console.WriteLine("\n");

            // Resize
            Console.WriteLine("Resize -------------\n");
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);
            Console.WriteLine("\n");

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);
            Console.WriteLine("\n");

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);
            Console.WriteLine("\n");

            // Sort
            Array.Sort(aulas);
            Imprimir(aulas);
            Console.WriteLine("\n");

            // Copy
            Console.WriteLine("Copy -------------\n");
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);
            Console.WriteLine("\n");

            // Clone
            Console.WriteLine("Clone -------------\n");
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);
            Console.WriteLine("\n");

            //Clear
            Console.WriteLine("Clear -------------\n");
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
            Console.WriteLine("\n");


        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
