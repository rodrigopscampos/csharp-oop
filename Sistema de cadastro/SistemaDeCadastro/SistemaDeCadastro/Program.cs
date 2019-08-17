using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1 - Listar Todos");
            Console.WriteLine("2 - Adicionar");
            Console.WriteLine("3 - Consultar");
            Console.WriteLine("4 - Excluir");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                int opc = LerOpcao();

                if (opc == 1)
                {
                    ListarTodos();
                }
                else if (opc == 2)
                {
                    Adicionar();
                }
                else if (opc == 3)
                {
                    Consultar();
                }
                else if (opc == 4)
                {
                    Excluir();
                }
                else
                {
                    OpcaoInvalida();
                }
            }
        }

        static void OpcaoInvalida()
        {

        }


        static int LerOpcao()
        {
            int opc;
            while(!int.TryParse(Console.ReadLine(), out opc))
            {
                Console.WriteLine("Entrada inválida");
            }

            return opc;
        }

        static void Inserir()
        {
            //ToDo: implementar o algoritmo
        }

        static void ListarTodos()
        {
            //ToDo: implementar o algoritmo
        }

        static void Adicionar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            var nascimentoStr = Console.ReadLine();

            DateTime dtNascimento;
            var sucesso = DateTime.TryParseExact(
                nascimentoStr,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dtNascimento);

            if (!sucesso)
            {
                Console.WriteLine("Data de nascimento inválida, tente novamente");
                return;
            }

            Repositorio.Cadastrar(nome, dtNascimento);
            Console.WriteLine("Usuário cadastrado com sucesso");
        }

        static void Consultar()
        {
            //ToDo: implementar o algoritmo
        }

        static void Excluir()
        {
            //ToDo: implementar o algoritmo
        }
    }
}
