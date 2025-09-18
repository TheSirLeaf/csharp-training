using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCommon
{
    public class Curso
    {
        public Curso(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                var aluno = Alunos[count];
                Console.WriteLine($"Aluno {count + 1}: {aluno.NomeCompleto}, Idade: {aluno.Idade}");
            }
        }
    }
}