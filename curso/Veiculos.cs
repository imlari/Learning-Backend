using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public class Veiculos
    {
        private string marca { get; set; }
        private string modelo { get; set; }
        private int ano { get; set; }

        public Veiculos(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public string Marca {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public int Ano {
            get { return this.ano; }
            set { this.ano = value; }
        }
    }
}