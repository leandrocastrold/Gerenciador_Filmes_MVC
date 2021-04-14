using Gerenciador_Series.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Gerenciador_Series.Web.Data
{
    public class LCFilmesDataContext : DbContext
    {

        public LCFilmesDataContext(DbContextOptions<LCFilmesDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    List<Categoria> categoryList = new List<Categoria>()
        //    {
        //        new Categoria() { Id = 1, Nome = "Luta", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 2, Nome = "Ação", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 3, Nome = "Aventura", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 4, Nome = "Suspense", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 5, Nome = "Terror", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 6, Nome = "Drama", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 7, Nome = "Sci-fi", DataCadastro = DateTime.Now },
        //        new Categoria() { Id = 8, Nome = "Adulto", DataCadastro = DateTime.Now },
        //        new Categoria() { Nome = "Infantil", DataCadastro = DateTime.Now }
        //    };
        //    Categorias.AddRange(categoryList);
        //}
    }

}

   

