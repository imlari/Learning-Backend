// using curso;

// var MeuCarro = new Carro
// {
//     Ano = 2002,
//     Cor = "Azul",
//     Modelo = "BMW",
//     Placa = "ABC-1234",
//     VelocidadeAtual = 60.0
// };

// var MyCar = new Carro("Ferrari", 100.0, 2021, "XYZ-9876", "Vermelho");

// MyCar.Acelerar( 20.0);
// MyCar.Frear(10.0);

// var minhaLampada = new Lampada(){
//     Estado = true,
//     Intensidade = 20
// };

// minhaLampada.LigarDesligar();

// minhaLampada.AjustarIntensidade(5);

// Console.WriteLine($"Estado: {minhaLampada.Estado}, Intensidade: {minhaLampada.Intensidade}");

using curso;

namespace Name
{
    public class Program
    {
        public static void Main()
        {
            var desenvolvedor = new Desenvolvedor("João", "TI", "C#", "Junior");
            var analista = new Analista("Carlos", "TI", "Java", "Pleno");

            desenvolvedor.Trabalhar();
            analista.Trabalhar();
        }
    }
}