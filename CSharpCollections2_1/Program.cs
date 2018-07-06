using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            // imprimindo
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }

            // removendo AL
            alunos.Remove("AL");

            // adicionando mais um aluno para mostrar que IDctionary não é ordenado automaticamente
            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Console.WriteLine();
            // imprimindo
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }

            // Criando SorteList
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));
            Console.WriteLine();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

        }
    }
}
