using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_4
{
    class Curso
    {
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;
        private int tempoTotal;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public string Nome { get => nome; set => nome = value; }
        public string Instrutor { get => instrutor; set => instrutor = value; }
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.Matricula, aluno);
        }

        public int TempoTotal { get => aulas.Sum(aula => aula.Tempo); }

        public override string ToString()
        {
            return $"\nCurso: {nome} \nTempo: {tempoTotal} \nAulas: {string.Join(", ", aulas)} \n"; 
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatricula(int matricula)
        {
            //foreach (var aluno in alunos)
            //{
            //    if (aluno.Matricula == matricula)
            //    {
            //        return aluno;
            //    }
            //}
            //throw new Exception($"Matricula não encontrada: {matricula}");

            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(matricula, out aluno);
            return aluno;
        }

    }
}
