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
    public class CadastroController : Controller
    {
        private readonly IRepository<Filme> _filmesRepository;
        private readonly IRepository<Serie> _seriesRepository ;
        private readonly IRepository<Categoria> _categoriaRepository;
        public CadastroController(LCFilmesDataContext ctx)
        {
            _filmesRepository = new FilmesRepositoryEF(ctx);
            _categoriaRepository = new CategoriasRepositoryEF(ctx);
            _seriesRepository = new SeriesRepositoryEF(ctx);
        }
        [HttpGet]
        public IActionResult CadastroFilmes(int? id)
        {
            var filme = new Filme();

            if (id != null)
            {
                filme = _filmesRepository.Get((int)id);
            }

            var listaCategoria = _categoriaRepository.Get();
            ViewBag.Categorias = listaCategoria;

            return View(filme);
        }

        [HttpPost]
        public IActionResult CadastroFilmes(Filme novoFilme)
        {
            if (novoFilme.Id == 0)
            {
                _filmesRepository.Add(novoFilme);
            }
            else
            {
                _filmesRepository.Edit(novoFilme);
            }

            return RedirectToAction("Filmes", "Filmes");
        }

        public ActionResult DeletarFilme(int id)
        {
            var filme = _filmesRepository.Get((int)id);

            if (filme == null)
            {
                return StatusCode(404);
            }
            _filmesRepository.Remove(filme);

            return StatusCode(200);
        }

        // CADASTRO DE SÉRIES

        public IActionResult CadastroSeries(int? id)
        {
            var serie = new Serie();
          
            if (id != null)
            {
                serie = _seriesRepository.Get((int)id);
            }

            var listaCategoria = _categoriaRepository.Get();
            ViewBag.Categorias = listaCategoria;
            return View(serie);
        }

        [HttpPost]
        public IActionResult CadastroSeries(Serie novaSerie)
        {
            if (novaSerie.Id == 0)
            {
                _seriesRepository.Add(novaSerie);
            }
            else
            {
                _seriesRepository.Edit(novaSerie);
            }

            return RedirectToAction("Series", "Filmes");
        }


        public IActionResult RemoverSerie(int id)
        {
            var serieToRemove = _seriesRepository.Get((int)id);

            if (serieToRemove == null)
            {
                return StatusCode(404);
            }

            _seriesRepository.Remove(serieToRemove);
            
            return StatusCode(200);
        }
      
        [HttpGet]
         public IActionResult CategoriasCadastro(int? id)
        {
            Categoria categoria = null;
            if (id != null)
            {
               categoria = _categoriaRepository.Get((int)id);
            }
            return View(categoria);
        }

        public IActionResult Categorias()
        {

            return View(_categoriaRepository.Get());
        }
        [HttpPost]
        public IActionResult CategoriasCadastro(Categoria categoria)
        {
            if (categoria.Id == 0)
            {
                _categoriaRepository.Add(categoria);
            }
            else
            {
                _categoriaRepository.Edit(categoria);
            }

            return RedirectToAction("Categorias", "Cadastro");
        }

        public IActionResult DeletarCategoria(int id)
        {
            var categoria = _categoriaRepository.Get(id);
            
            if (categoria == null)
            {
                return StatusCode(404);
            }
            _categoriaRepository.Remove(categoria);

            return StatusCode(200);
        }


        protected override void Dispose(bool disposing)
        {
            _filmesRepository.Dispose();
            _seriesRepository.Dispose();
        }

    }
}
