using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public class Smartphone : DispositivoEletronico
    {
        
        public string sistemaOperacional { get; set; }

        public int capacidadeBateria { get; set; }

        public Smartphone(string marca, string modelo, int anoDeFabricacao, string sistemaOperacional) : base(marca, modelo, anoDeFabricacao)
        {
            this.sistemaOperacional = sistemaOperacional;
        }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando o smartphone {marca} {modelo} {anoDeFabricacao} {sistemaOperacional}");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando o smartphone {marca} {modelo} {anoDeFabricacao} {sistemaOperacional}");
        }

         public override int VerificarBateria()
        {
            return capacidadeBateria;
        }

        public string VerificarBateria(int capacidadeBateria)
        {
            return $"A bateria está em {capacidadeBateria}%";
        }

        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}, Sistema Operacional: {sistemaOperacional}";
        }
    }
}