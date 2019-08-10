using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Lista2;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = TimeSpan.FromMilliseconds(100);
            var t2 = new TimeSpan(0, 0, 0, 0, 100);

            Pessoa p = Pessoa.CriarComIdade("Rodrigo", 25);
            var p2 = Pessoa.CriarComNascimento("Pessoa2", 2018);

            var arrayElastico = new ArrayElastico();
            var arrayElastico2 = new ArrayElastico(200);
            var arrayElastico3 = new ArrayElastico(200, true);
            var arrayElastico4 = new ArrayElastico(logLigado: true, tamInicial:20);



        }
    }
}
