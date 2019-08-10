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
        }
    }
}
