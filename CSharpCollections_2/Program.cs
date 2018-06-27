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
            // declaração de variaveis
            ISet<string> alunos = new HashSet<string>();

            // adicionando alunos
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(string.Join(", ", alunos));

            // removendo a Ana e adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");

            Console.WriteLine(string.Join(", ", alunos));

            // sort HashSet

            List<string> copiaAlunos = new List<string>(alunos);

            copiaAlunos.Sort();

            Console.WriteLine(string.Join(", ", copiaAlunos));
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}


            //aulas.ForEach(aula =>
            //{
            //    Console.WriteLine(aula);
            //});

            //Console.WriteLine("\n");
        }
    }

    
}
