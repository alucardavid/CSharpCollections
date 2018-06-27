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

            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

            Imprimir(csharpColecoes.Aulas);

            // adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            // Imprimir
            Imprimir(csharpColecoes.Aulas);

            // Ordenando a lista de aulas
            //csharpColecoes.Aulas.Sort();

            // copiando a lista de aulas
            List<Aula> copia = new List<Aula>(csharpColecoes.Aulas);

            // Ordenar a cópia
            copia.Sort();

            Imprimir(copia);

            // totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

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
