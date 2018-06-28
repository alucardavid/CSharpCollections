using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando novo curso
            Curso curso = new Curso("C# Colecoes", "David Pereira");

            // Adicionando 3 aulas a esse curso
            curso.Adiciona(new Aula("Trabalhando com Listas", 21));
            curso.Adiciona(new Aula("Criando uma Aula", 21));
            curso.Adiciona(new Aula("Modelando com Coleçoes", 21));

            // Adicionando 3 alunos
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Lonask", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            curso.Matricula(a1);
            curso.Matricula(a2);
            curso.Matricula(a3);

            // Imprimindo os alunos matriculados

            foreach (var aluno in curso.Alunos)
            {
                Console.WriteLine(aluno);
            }

            // Verificando se o aluno esta matriculado 
            Console.WriteLine(curso.EstaMatriculado(a1));

            Console.Clear();

            // Verificando se uma nova instancia com as mesmas informações da instancia anterior esta matriculado
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("Tonini esta matriculada? " + curso.EstaMatriculado(tonini));

            // Teste booleano 
            Console.WriteLine(a1 == tonini);

            // Utilizando Equals
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));

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
