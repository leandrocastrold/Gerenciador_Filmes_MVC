using Gerenciador_Series.Web.interfaces;
using Gerenciador_Series.Web.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Series.Web.Data.Repositories
{
    public class RepositoryEF<T> : IRepository<T> where T : Entity
    {
        protected readonly LCFilmesDataContext _ctx;

        public RepositoryEF(LCFilmesDataContext context)
        {
            _ctx = context;
        }
        public IEnumerable<T> Get()
        {
            var list =_ctx.Set<T>().ToList();
            return list;
        }

        public T Get(int id)
        {
            var item = _ctx.Set<T>().Find(id);
            return item;
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
            Save();
        }

        public void Edit(T entity)
        {
            _ctx.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public void Remove(T entity)
        {
            _ctx.Set<T>().Remove(entity);
            Save();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
