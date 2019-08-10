using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.HerancaPolimorfismo
{
    //Crie uma classe Figura2D com o métodos 
    //CalcularArea e as propriedades Base e Altura.

    public abstract class Figura2D
    {
        public abstract float CalcularArea();

        public static Figura2D Maior(params Figura2D[] figuras)
        {
            var maior = figuras[0];
            var area = maior.CalcularArea();

            foreach (var item in figuras)
            {
                if (item.CalcularArea() > area)
                {
                    maior = item;
                    area = maior.CalcularArea();
                }
            }

            return maior;
        }

        public override string ToString()
        {
            var area = CalcularArea();
            var nome = GetType().Name;

            return $"Figura: {nome}. Area: {area}";
        }
    }

    public abstract class Figura2DBaseAltura : Figura2D
    {
        public float Base { get; }
        public float Altura { get; set; }

        public Figura2DBaseAltura(float @base, float altura)
        {
            this.Base = @base;
            this.Altura = altura;
        }
    }

    public class Retangulo : Figura2DBaseAltura
    {
        public Retangulo(float @base, float altura) 
            : base(@base, altura)
        {
        }

        public override float CalcularArea()
        {
            return Base * Altura;
        }
    }

    public class Triangulo : Figura2DBaseAltura
    {
        public Triangulo(float @base, float altura) 
            : base(@base, altura)
        {
        }

        public override float CalcularArea()
        {
            return Base * Altura / 2;
        }
    }

    public class Circulo : Figura2D
    {
        public float Raio { get; }

        public Circulo(int raio)
        {
            this.Raio = raio;
        }

        public override float CalcularArea()
        {
            //formula: A = PI * R * R
            
            return (float)Math.PI * Raio * Raio;
        }
    }
}
