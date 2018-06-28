using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_3
{
    class Aluno
    {
        private string nome;
        private int matricula;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, Matricula: {matricula}";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

    }
}
