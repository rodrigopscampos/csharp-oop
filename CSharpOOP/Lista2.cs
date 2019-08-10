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
        public string Nome { get; private set; }
        public int AnoNascimento { get; private set; }
        public int Idade { get; private set; }

        private Pessoa() { }

        public static Pessoa CriarComIdade(string nome, int idade) =>
            new Pessoa()
            {
                Nome = nome,
                Idade = idade,
                AnoNascimento = DateTime.Now.Year - idade
            };

        public static Pessoa CriarComNascimento(string nome, int anoNascimento)
        {
            var p = new Pessoa();
            p.Nome = nome;
            p.AnoNascimento = anoNascimento;
            p.Idade = DateTime.Now.Year - anoNascimento;

            return p;
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
        public int QtdAlunos { get; }
        private string[] _alunos;
        private int _posicaoAtual;

        public Turma(int qtdAlunos)
        {
            QtdAlunos = qtdAlunos;
            _posicaoAtual = 0;
            _alunos = new string[QtdAlunos];
        }

        public void AdicionarAluno(string aluno)
        {
            _alunos[_posicaoAtual] = aluno;
            _posicaoAtual++;
        }

        public void Listar()
        {
            for (int i = 0; i < _posicaoAtual; i++)
            {
                Console.WriteLine(_alunos[i]);
            }
        }
    }

    //Implemente um classe ArrayDinamico, como os métodos Adicionar e Pegar
    public class ArrayElastico
    {
        private int[] _array;
        private int _posicaoArray = 0;
        private bool _logLigado;

        public ArrayElastico(int tamInicial = 10, bool logLigado = false)
        {
            _array = new int[tamInicial];
            _logLigado = logLigado;
        }

        public void Add(int item)
        {
            if (_array.Length == _posicaoArray)
            {
                DrobrarTamanhoArray();
            }

            _array[_posicaoArray] = item;
            _posicaoArray++;
        }

        public int Pegar(int indice) => _array[indice];

        private void DrobrarTamanhoArray()
        {
            int[] novoArray = new int[_array.Length * 2];

            for (int i = 0; i < _array.Length; i++)
            {
                novoArray[i] = _array[i];
            }

            _array = novoArray;

            if(_logLigado)
            {
                Console.WriteLine("Tamanho do array dobrado para " + _array.Length);
            }
        }
    }
}
