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
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            // Criando e adicionar a lista de objetos
            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            // Sort default implementado pela IComparable
            aulas.Sort();
            Imprimir(aulas);

            // Sort com outro campo [tempo]
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);


        }

        private static void Imprimir(List<Aula> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            Console.Clear();

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

            Console.WriteLine("\n");
        }
    }

    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;

            return this.titulo.CompareTo(that.titulo);
        }

        public override string ToString()
        {
            return $"[titulo: {titulo}, tempo: {tempo} minutos]"; 
        }

    }
}
