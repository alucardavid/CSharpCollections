using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollection_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            // Conectando duas sequências
            Console.WriteLine("Conectando duas sequências");
            var consulta = seq1.Concat(seq2);
            Imprimir(consulta);

            // União de duas sequências
            Console.WriteLine("União de duas sequências");
            var consulta2 = seq1.Union(seq2);
            Imprimir(consulta2);

            // União de duas sequências com comparador
            Console.WriteLine("União de duas sequências com comparador");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            Imprimir(consulta3);

            // Intersecção de duas sequências
            Console.WriteLine("Intersecção de duas sequências");
            var consulta4 = seq1.Intersect(seq2);
            Imprimir(consulta4);

            // Exceto: elementos da seq1 que não estão em seq2
            Console.WriteLine("Exceto: elementos da seq1 que não estão em seq2");
            var consulta5 = seq1.Except(seq2);
            Imprimir(consulta5);

        }

        private static void Imprimir(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
