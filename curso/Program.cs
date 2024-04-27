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
using curso.Formas;
using curso.Notification;

namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var desenvolvedor = new Desenvolvedor("João", "TI", "C#", "Junior");
            var analista = new Analista("Carlos", "TI", "Java", "Pleno");

            desenvolvedor.Trabalhar();
            analista.Trabalhar();

            var tablet = new Tablet("Samsung", "Galaxy Tab", 2020, "10.1");
            var smartphone = new Smartphone("Apple", "iPhone 12", 2020, "iOS");

            tablet.Ligar();
            tablet.Desligar();

            smartphone.Ligar();
            smartphone.Desligar();

            tablet.capacidadeBateria = 90;
            smartphone.capacidadeBateria = 57;

            Console.WriteLine($"Bateria do tablet: {tablet.VerificarBateria(tablet.capacidadeBateria)}");
            Console.WriteLine($"Bateria do smartphone: {smartphone.VerificarBateria(smartphone.capacidadeBateria)}");

            Console.WriteLine(tablet.ObterDescricao());
            Console.WriteLine(smartphone.ObterDescricao());

            // var notificacoes = new List<INotificacao>
            // {
            //     new EmailNotificacao(),
            //     new SMSNotificacao(),
            //     new PushNotificacao()
            // };

            #region Notificacoes
            List<INotificacao> notificacoes = new List<INotificacao>();
            notificacoes.Add(new EmailNotificacao());
            notificacoes.Add(new SMSNotificacao());
            notificacoes.Add(new PushNotificacao());

            foreach (var notificacao in notificacoes)
            {
                notificacao.Enviar("Mensagem de teste");
            }

            #endregion


            #region Forma
            List<Forma> formas = new List<Forma>();
            formas.Add(new Circulo(5));
            formas.Add(new Retangulo(3, 4));

            foreach (var forma in formas)
            {
                forma.Desenhar();
            }

            #endregion

            #region 02-05

            List<Livro> biblioteca = new List<Livro>

            {
            new Livro { Titulo = "A História do Amanhã", Autor = "Yuval Noah Harari", NumeroDePaginas = 500, 
            Categoria = "História" },
            new Livro { Titulo = "Sapiens", Autor = "Yuval Noah Harari", NumeroDePaginas = 450, Categoria = 
            "Antropologia" },
            new Livro { Titulo = "1984", Autor = "George Orwell", NumeroDePaginas = 328, Categoria = "Ficção" },
            new Livro { Titulo = "O Sol é Para Todos", Autor = "Harper Lee", NumeroDePaginas = 384, Categoria = 
            "Ficção" },
            new Livro { Titulo = "A Revolução dos Bichos", Autor = "George Orwell", NumeroDePaginas = 112, 
            Categoria = "Ficção" },
            new Livro { Titulo = "Cem Anos de Solidão", Autor = "Gabriel García Márquez", NumeroDePaginas = 
            417, Categoria = "Ficção" },
            new Livro { Titulo = "Os Miseráveis", Autor = "Victor Hugo", NumeroDePaginas = 1463, Categoria = 
            "Ficção Histórica" },
            new Livro { Titulo = "Crime e Castigo", Autor = "Fyodor Dostoevsky", NumeroDePaginas = 671, 
            Categoria = "Ficção" },
            new Livro { Titulo = "Breves Respostas para Grandes Questões", Autor = "Stephen Hawking", 
            NumeroDePaginas = 256, Categoria = "Ciência" },
            new Livro { Titulo = "Uma Breve História do Tempo", Autor = "Stephen Hawking", NumeroDePaginas = 
            212, Categoria = "Ciência" },
            new Livro { Titulo = "Os Elementos da Experiência do Usuário", Autor = "Jesse James Garrett", 
            NumeroDePaginas = 208, Categoria = "Design" },
            new Livro { Titulo = "Design de Interação", Autor = "Jenny Preece", NumeroDePaginas = 809, Categoria
            = "Design" },
            new Livro { Titulo = "O Poder do Hábito", Autor = "Charles Duhigg", NumeroDePaginas = 400, 
            Categoria = "Autoajuda" },
            new Livro { Titulo = "Como Fazer Amigos e Influenciar Pessoas", Autor = "Dale Carnegie", 
            NumeroDePaginas = 288, Categoria = "Autoajuda" },
            new Livro { Titulo = "Subliminar", Autor = "Leonard Mlodinow", NumeroDePaginas = 304, Categoria = 
            "Psicologia" },
            new Livro { Titulo = "Freakonomics", Autor = "Steven D. Levitt", NumeroDePaginas = 336, Categoria = 
            "Economia" },
            new Livro { Titulo = "Outliers", Autor = "Malcolm Gladwell", NumeroDePaginas = 336, Categoria = 
            "Psicologia" },
            new Livro { Titulo = "Don't Make Me Think", Autor = "Steve Krug", NumeroDePaginas = 200, Categoria 
            = "Tecnologia" },
            new Livro { Titulo = "O Andar do Bêbado", Autor = "Leonard Mlodinow", NumeroDePaginas = 272, 
            Categoria = "Ciência" },
            new Livro { Titulo = "O Gene Egoísta", Autor = "Richard Dawkins", NumeroDePaginas = 360, Categoria 
            = "Biologia" },
            new Livro { Titulo = "O Mundo Assombrado pelos Demônios", Autor = "Carl Sagan", NumeroDePaginas 
            = 480, Categoria = "Ciência" }
            };

            var listOfBooksByCategory = biblioteca
                .GroupBy(livro => livro.Categoria)
                .Select(group => new
                {
                    Categoria = group.Key,
                    Livros = group.OrderBy(livro => livro.Titulo)
                }).ToList();
            
          
            var longBooks = biblioteca
            .Where(livro => livro.NumeroDePaginas > 400)
            .ToList();

            var booksByAuthor = biblioteca
            .GroupBy(livro => livro.Autor)
            .Select(group => new
            {
                Autor = group.Key,
                Livros = group.Count()
            }).ToList();

            var booksWithHistoryOnItsTitle = biblioteca
            .Where(livro => livro.Titulo.Contains("história", StringComparison.CurrentCultureIgnoreCase))
            .ToList();

            var authorsWithMoreThanOneBook = biblioteca
            .GroupBy(livro => livro.Autor)
            .Where(group => group.Count() > 1)
            .ToList();
            
            #endregion
        }
    }
}