﻿using System;
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

            // Get last and fist in diferently ways.
            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A última aula é " + aulas[aulas.Count -1]);

            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A última aula é " + aulas.Last());


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