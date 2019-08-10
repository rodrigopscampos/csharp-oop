using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Lista2
{
    //Implemente uma classe Pessoa, com nome e ano de nascimento e com o 
    //método Comprimentar que imprime “Olá eu sou {nome} e tenho {idade} anos”

    public class Pessoa
    {
        public string Nome;
        public int AnoNascimento;
        public int Idade;

        public Pessoa(string nome, int anoNascimento)
        {
            this.Nome = nome;
            this.AnoNascimento = anoNascimento;
            this.Idade = DateTime.Now.Year - anoNascimento;
        }

        public void Comprimentar()
        {
            Console.WriteLine($"Olá eu sou {Nome} e tenho {Idade} anos");
        }
    }

    //Implemente uma classe Turma, que recebe a quantidade de alunos, 
    //possui o método AdicionarAluno, 
    //que recebe uma string e o método Listar que imprime a lista de alunos.


    public class Turma
    {
        public int QtdAlunos;
        public string[] Alunos;
        public int PosicaoAtual;

        public Turma(int qtdAlunos)
        {
            QtdAlunos = qtdAlunos;
            PosicaoAtual = 0;
            Alunos = new string[QtdAlunos];
        }

        public void AdicionarAluno(string aluno)
        {
            Alunos[PosicaoAtual] = aluno;
            PosicaoAtual++;
        }

        public void Listar()
        {
            for(int i = 0; i < PosicaoAtual; i++)
            {
                Console.WriteLine(Alunos[i]);
            }
        }
    }

}
