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
            // Instanciando uma nova lista ligada: Dias da semana
            LinkedList<string> dias = new LinkedList<string>();

            // Criando quarta
            var d4 = dias.AddFirst("quarta");

            // get value of d4
            Console.WriteLine($"d4.Value: {d4.Value}");

            // criando segunda
            var d2 = dias.AddBefore(d4, "segunda");

            // criando terça
            var d3 = dias.AddAfter(d2, "terça");

            // criando sexta
            var d6 = dias.AddAfter(d4, "sexta");

            // criando sabado
            var d7 = dias.AddAfter(d6, "sabado");

            // criando quinta
            var d5 = dias.AddBefore(d6, "quinta");

            // criando domingo
            var d1 = dias.AddBefore(d2, "domingo");

            // metodo find
            var quarta = dias.Find("quarta");

            // removendo um item
            dias.Remove("quarta");
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            
        }
    }
}
