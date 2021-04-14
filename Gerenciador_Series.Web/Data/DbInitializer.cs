//using Gerenciador_Series.Web.Models;
//using System.Collections.Generic;

//namespace Gerenciador_Series.Web.Data
//{
//    internal class DbInitializer :   CreateDatabaseIfNotExists<LCFilmesDataContext>
//    {
//        protected override void Seed(LCFilmesDataContext context)
//        {
//            var acao = new Categoria() { Nome = "Ação" };
//            var aventura = new Categoria() { Nome = "Aventura" };
//            var drama = new Categoria() { Nome = "Drama" };
//            var luta = new Categoria() { Nome = "Luta" };
//            var terror = new Categoria() { Nome = "Terror" };
//            var suspense = new Categoria() { Nome = "Suspense" };
//            var animacao = new Categoria() { Nome = "Animação" };
//            var categorias = new Categoria() { Nome = "Animação" };
//            var infantil = new Categoria() { Nome = "Infantil" };

//            var filmes = new List<Filme>()
//            {
//                new Filme() { Nome = "Corra que a polícia vem aí", Duracao = 1.5, Categoria = acao },
//                new Filme() { Nome = "Top Gun", Duracao = 1.3,  Categoria = acao },
//                new Filme() { Nome = "indiana Jones", Duracao = 2.0, Categoria = aventura},
//                new Filme() { Nome = "Coringa", Duracao = 1.55, Categoria = drama},
//                new Filme() { Nome = "Soul", Duracao = 1.30, Categoria = animacao},
//                new Filme() { Nome = "A freira", Duracao = 2.0, Categoria = terror},
//                new Filme() { Nome = "O Grito", Duracao = 1.45, Categoria = suspense},
//                new Filme() { Nome = "Bob Esponja", Duracao = 1.45, Categoria = animacao},
//                new Filme() { Nome = "Kung Fusão", Duracao = 1.25, Categoria = luta},
//            };

//            var series = new List<Serie>()
//            {
//             new Serie() {Nome = "The Witcher", NumEpisodios = 15, Categoria = aventura},
//             new Serie() {Nome = "Breaking Bad", NumEpisodios = 45, Categoria = drama},
//             new Serie() {Nome = "Gambito da Rainha", NumEpisodios = 20, Categoria = drama},
//            };



//            context.Filmes.AddRange(filmes);
//            context.Series.AddRange(series);

//            context.SaveChanges();

//        }
//    }
//}