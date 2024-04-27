using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace curso
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public double VelocidadeAtual { get; set; }
        public Carro(string modelo, double velocidadeAtual, int ano, string placa, string cor){
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
            Ano = ano;
            Placa = placa;
            Cor = cor;
        }
        public Carro() {

        }
        public void Acelerar(double incremento){
            this.VelocidadeAtual += incremento;
            Console.WriteLine($"A velocidade do carro subiu para {this.VelocidadeAtual}");
        }
        public void Frear(double decremento){
            this.VelocidadeAtual -= decremento;
            Console.WriteLine($"A velocidade do carro desceu para {this.VelocidadeAtual}");
        }
        public string Ligar(){
            return "O carro está ligado";
        }
        public void Desligar(){
            Console.WriteLine("O carro está desligado");
        }
    }
}