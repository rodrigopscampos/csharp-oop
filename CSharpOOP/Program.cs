using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOOP.Lista2;
using CSharpOOP.HerancaPolimorfismo;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var circulo = new Circulo(10);
            var triangulo = new Triangulo(2, 5);

            var maior = Figura2D.Maior(circulo, triangulo);

            Console.WriteLine(maior);
            Console.ReadLine();

            int vogais;
            int consoantes;

            CategorizaTexto("Olá mundo", out vogais, out consoantes);
        }

        static void CategorizaTexto(string texto, out int qtVogais, out int qtConsoantes)
        {
            qtConsoantes = 0;
            qtVogais = 0;
        }

        static void M2(out int n)
        {
            n = 0;
        }
    }
}
