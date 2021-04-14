using Gerenciador_Series.Web.Data;
using Gerenciador_Series.Web.Data.Repositories;
using Gerenciador_Series.Web.interfaces;
using Gerenciador_Series.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.Controllers
{
    public class FilmesController : Controller
    {
        private readonly IRepository<Filme> _filmesRepository;
        private readonly IRepository<Serie> _seriesRepository;
        private readonly IRepository<Categoria> _categoriaRepository;
        public FilmesController(LCFilmesDataContext ctx)
        {
            _filmesRepository = new FilmesRepositoryEF(ctx);
            _categoriaRepository = new CategoriasRepositoryEF(ctx);
            _seriesRepository = new SeriesRepositoryEF(ctx);
        }
        
        public IActionResult Filmes()
        {

            var filmes = _filmesRepository.Get() ;

            var listaCategoria = _categoriaRepository.Get();
            ViewBag.Categorias = listaCategoria;
            return View(filmes);
        }

        public IActionResult Series()
        {
            var series = _seriesRepository.Get();
            var listaCategoria = _categoriaRepository.Get();
            ViewBag.Categorias = listaCategoria;
            return View(series);
        }

        public IActionResult Categorias()
        {
            var categorias = _categoriaRepository.Get();
            return View(categorias);
        }
    }
}
