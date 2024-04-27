using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso
{
    public class Tablet : DispositivoEletronico
    {
        public string tamanhoTela { get; set; }

        public int capacidadeBateria { get; set; }

        public Tablet(string marca, string modelo, int anoDeFabricacao, string tamanhoTela) : base(marca, modelo, anoDeFabricacao)
        {
            this.tamanhoTela = tamanhoTela;
        }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando o tablet {marca} {modelo} {anoDeFabricacao} {tamanhoTela}");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando o tablet {marca} {modelo} {anoDeFabricacao} {tamanhoTela}");
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
            return $"{base.ObterDescricao()}, Tamanho da tela: {tamanhoTela}";
        }
    }
}