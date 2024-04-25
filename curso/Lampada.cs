using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public class Lampada
    {
        public bool Estado { get; set; }
        public int Intensidade { get; set; }
        public Lampada() {
            Estado = false;
            Intensidade = 0;
        }
        public Lampada(bool estado, int intensidade) {
            Estado = estado;
            Intensidade = intensidade;
        }
        public void LigarDesligar() {
            Estado = !Estado;
            if (Estado) {
                Console.WriteLine("Lâmpada ligada");
            } else {
                Console.WriteLine("Lâmpada desligada");
            }
        }
        public void AjustarIntensidade(int novaIntensidade) {
            if (Intensidade < 0 || Intensidade > 10) {
                Console.WriteLine("Intensidade deve ser entre 0 e 10");
                return;
            }
            Intensidade = novaIntensidade;
        }
    }
}