using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
        public abstract class Funcionario
        {
            private string nome { get; set; }
            private string departamento { get; set; }

            public Funcionario(string nome, string departamento)
            {
                this.nome = nome;
                this.departamento = departamento;
            }

            public string Nome {
                get { return this.nome; }
                set { this.nome = value; }
            }

            public string Departamento {
                get { return this.departamento; }
                set { this.departamento = value; }
            }

            public abstract void Trabalhar();          
        }
}