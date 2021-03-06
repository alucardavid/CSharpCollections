﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando lista de meses e dias
            List<Mes> meses = new List<Mes>
            {
                            new Mes("Janeiro", 31),
                            new Mes("Fevereiro", 28),
                            new Mes("Março", 31),
                            new Mes("Abril", 30),
                            new Mes("Maio", 31),
                            new Mes("Junho", 30),
                            new Mes("Julho", 31),
                            new Mes("Agosto", 31),
                            new Mes("Setembro", 30),
                            new Mes("Outubro", 31),
                            new Mes("Novembro", 30),
                            new Mes("Dezembro", 31)
            };


            


        }
    }

    internal class Mes
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public override string ToString()
        {
            return $"{Nome} - {Dias}";
        }

    }
}
