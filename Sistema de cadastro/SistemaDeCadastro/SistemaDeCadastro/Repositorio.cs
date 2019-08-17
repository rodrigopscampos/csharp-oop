using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    public static class Repositorio
    {
        private static int _id = 0;
        private static List<Cliente> _clientes 
            = new List<Cliente>();

        public static void Cadastrar(
            string nome,
            DateTime dtNascimento)
        {
            _id++;
            var c = new Cliente(_id, nome, dtNascimento);
            _clientes.Add(c);
        }
    }
}
