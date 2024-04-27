using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.Formas
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um retângulo de largura {Largura} e altura {Altura}");
        }
    }
}