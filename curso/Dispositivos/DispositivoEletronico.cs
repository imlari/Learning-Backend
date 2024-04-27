using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public abstract class DispositivoEletronico
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anoDeFabricacao { get; set; }

        public DispositivoEletronico(string marca, string modelo, int anoDeFabricacao)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anoDeFabricacao = anoDeFabricacao;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public virtual string ObterDescricao()
        {
            return $"Marca: {marca}, Modelo: {modelo}";
        }

        public virtual int VerificarBateria()
        {
            return -1;
        }
    }
}