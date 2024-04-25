using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public class Motocicleta : Veiculos
    {
        private int cilindrada { get; set; }

        public Motocicleta(string marca, string modelo, int ano, int cilindrada): base(marca, modelo, ano)
        {
            this.cilindrada = cilindrada;
        }

       public int Cilindrada {
           get { return this.cilindrada; }
           set { this.cilindrada = value; }
       }

    }
}