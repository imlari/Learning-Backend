using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.Formas
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public Circulo(double raio)
        {
            this.Raio = raio;
        }
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um círculo de raio {Raio}");
        }
    }
}