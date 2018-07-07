using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] resultados = new string[3,3]
            {
                {"Alemanha", "Espanha", "Itália"},
                {"Argentina", "Holanda", "França"},
                {"Holanda", "Alemanha", "Alemanha"}
            };

            foreach (var selecao in resultados)
            {
                Console.WriteLine(selecao);
            }
        }
    }
}
