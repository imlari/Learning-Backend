using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public class Desenvolvedor : Funcionario
    {
        private string linguagem { get; set; }
        private string nivel { get; set; }
        private int anosDeExperiencia { get; set; }

        public Desenvolvedor(string nome, string departamento, string linguagem, string nivel): base(nome, departamento)
        {
            this.linguagem = linguagem;
            this.nivel = nivel;
        }

        public string Linguagem {
            get { return this.linguagem; }
            set { this.linguagem = value; }
        }

        public string Nivel {
            get { return this.nivel; }
            set { this.nivel = value; }
        }

        public int AnosDeExperiencia {
            get { return this.anosDeExperiencia; }
            set { this.anosDeExperiencia = value; }
        }

        public override void Trabalhar()
        {
            Console.WriteLine($"O desenvolvedor {this.Nome} está trabalhando com a linguagem {this.Linguagem} no departamento {this.Departamento}...");
        }
    }
}